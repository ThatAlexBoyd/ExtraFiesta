using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldMapUI : MonoBehaviour
{
    [SerializeField]
    private GameObject cityButtonPrefab;

    [SerializeField]
    private GameObject worldMapPanel;


    public void CreateMap(List<City> citiesToCreate)
    {
        for (int i = 0; i < citiesToCreate.Count; i++)
        {
            GameObject buttonPrefab = Instantiate(cityButtonPrefab, worldMapPanel.transform) as GameObject;
            buttonPrefab.GetComponent<CityButton>().SetupCityButton(citiesToCreate[i]);
        }
    }

    public void ToggleMap(bool status)
    {
        worldMapPanel.SetActive(status);
    }
}
