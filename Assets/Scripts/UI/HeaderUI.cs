using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeaderUI : MonoBehaviour
{

    [SerializeField]
    private TMP_Text displayTruckName;

    [SerializeField]
    private TMP_Text displayMoney;


    internal void InitializeHeader(string truckName, int money)
    {
        displayTruckName.text = truckName;
        displayMoney.text = money.ToString();
    }
}
