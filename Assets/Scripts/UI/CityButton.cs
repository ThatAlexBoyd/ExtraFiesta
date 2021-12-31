using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CityButton : MonoBehaviour
{
    [SerializeField]
    private TMP_Text  label;

    public void SetupCityButton(City city)
    {
        label.text = city.DisplayName;
    }
}
