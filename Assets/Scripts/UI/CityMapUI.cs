using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMapUI : MonoBehaviour
{
    [SerializeField]
    private GameObject locationButtonPrefab;

    [SerializeField]
    private GameObject cityMapPanel;


    public void CreateMap(List<Marker> locationToCreate)
    {
        ToggleMap(true);

        for (int i = 0; i < locationToCreate.Count; i++)
        {
            GameObject buttonPrefab = Instantiate(locationButtonPrefab, cityMapPanel.transform) as GameObject;
            buttonPrefab.GetComponent<LocationButton>().SetupLocationButton(locationToCreate[i]);
        }
    }

    public void ToggleMap(bool status)
    {
        cityMapPanel.SetActive(status);
    }

}
