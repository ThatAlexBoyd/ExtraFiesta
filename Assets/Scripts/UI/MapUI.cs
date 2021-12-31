using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapUI : MonoBehaviour
{
    [SerializeField]
    private List<City> cityList = new List<City>();

    [SerializeField]
    private CityButton cityButtonPrefab;

    [SerializeField]
    private GameObject mapPanel;



    private void Start()
    {
        CreateMap();
    }

    private void CreateMap()
    {
        for (int i = 0; i < cityList.Count; i++)
        {
            Instantiate(cityButtonPrefab, mapPanel.transform);
            cityButtonPrefab.SetupCityButton(cityList[i]);
        }
    }
}
