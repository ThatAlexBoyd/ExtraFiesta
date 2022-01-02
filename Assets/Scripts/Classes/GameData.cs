using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    private static GameData instance;
    public static GameData Instance { get { return instance; } }

    public List<City> CityList { get => cityList;}

    [SerializeField]
    private List<City> cityList = new List<City>();


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
}
