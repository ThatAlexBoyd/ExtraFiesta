using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance { get { return instance; } }

    private Location currentLocation;

    private GameController() { }

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
    }

    //Called whenever a CityButton is pressed
    public void CitySelected(City citySelected)
    {
        currentLocation = citySelected;
    }
}
