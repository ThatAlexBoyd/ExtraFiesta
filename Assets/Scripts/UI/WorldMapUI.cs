using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldMapUI : MonoBehaviour
{
    [SerializeField]
    private GameObject cityButtonPrefab;

    [SerializeField]
    private GameObject mapPanel;


    public void CreateMap()
    {
        List<City> cityListCopy = GameData.Instance.CityList; //cache city list from game data

        for (int i = 0; i < cityListCopy.Count; i++)
        {
            GameObject buttonPrefab = Instantiate(cityButtonPrefab, mapPanel.transform) as GameObject;
            buttonPrefab.GetComponent<CityButton>().SetupCityButton(cityListCopy[i]);
        }
    }
}
