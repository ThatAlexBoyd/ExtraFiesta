using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance { get { return instance; } }

    private Player currentPlayer;

    private Location currentLocation;

    [Header("UI Elements")]
    public HeaderUI headerPanel;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        StartGame();
    }

    private void StartGame()
    {
        if (currentPlayer == null)
            currentPlayer = new Player("Taco Truck", 99999);
        else
            Debug.Log("Loading saved game"); //load player data from save

        SetHeaderVales();
    }

    private void SetHeaderVales()
    {
        headerPanel.InitializeHeader(currentPlayer.TruckName, currentPlayer.Money);
    }

    //Called whenever a CityButton is pressed
    public void CitySelected(City citySelected)
    {
        currentLocation = citySelected;
    }
}
