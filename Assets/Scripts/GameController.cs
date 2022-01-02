using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance { get { return instance; } }

    private Player currentPlayer;

    private Location currentCity;

    [Header("UI Elements")]
    [SerializeField]
    private HeaderUI headerPanel;

    [SerializeField]
    private MapUI mapPanel;

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
        CreateMap();
    }

    #region Setup Logic
    private void CreatePlayer()
    {
        if (currentPlayer == null)
            currentPlayer = new Player("Taco Truck", 99999);
        else
            Debug.Log("Loading saved game"); //load player data from save
    }

    private void CreateMap()
    {
        mapPanel.CreateMap();
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
    }
}
