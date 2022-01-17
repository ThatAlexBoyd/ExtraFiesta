using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance { get { return instance; } }

    public GameData gameData;

    private Player currentPlayer;

    private City currentCity;

    [Header("UI Elements")]
    [SerializeField] private HeaderUI headerPanel;

    [SerializeField] private WorldMapUI worldMap;

    [SerializeField] private CityMapUI cityMap;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this.gameObject);
        else
            instance = this;

        StartGame();
    }

    private void StartGame()
    {
        CreatePlayer();
        SetHeaderVales();
        CreatWorldMap();
    }

    #region Setup Logic
    private void CreatePlayer()
    {
        if (currentPlayer == null)
            currentPlayer = new Player("Taco Truck", 99999);
        else
            Debug.Log("Loading saved game"); //load player data from save
    }

    private void CreatWorldMap()
    {
        worldMap.CreateMap(gameData.CityList);
    }

    private void CreatCityMap()
    {
        cityMap.CreateMap(currentCity.Locations);
    }

    private void SetHeaderVales()
    {
        headerPanel.InitializeHeader(currentPlayer.TruckName, currentPlayer.Money);
    }
    #endregion

    //Called whenever a CityButton is pressed
    public void CitySelected(City citySelected)
    {
        currentCity = citySelected;
        worldMap.ToggleMap(false);
        CreatCityMap();
    }
}
