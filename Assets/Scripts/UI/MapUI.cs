using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapUI : MonoBehaviour
{
    [SerializeField]
    private GameObject cityButtonPrefab;

    [SerializeField]
    private GameObject mapPanel;



    private void Start()
    {
        CreateMap();
    }

    private void CreateMap()
    {
        List<City> cityListCopy = GameData.Instance.CityList;

        for (int i = 0; i < cityListCopy.Count; i++)
        {
            GameObject buttonPrefab = Instantiate(cityButtonPrefab, mapPanel.transform) as GameObject;
            buttonPrefab.GetComponent<CityButton>().SetupCityButton(cityListCopy[i]);
        }
    }
}
