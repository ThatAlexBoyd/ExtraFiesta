using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    [SerializeField]
    private int money;
    public int Money { get => money; set => money = value; }

    [SerializeField]
    private string truckName;
    public string TruckName { get => truckName; set => truckName = value; }

    public Player(string savedTruckName, int savedMoney)
    {
        TruckName = savedTruckName;
        Money = savedMoney;
    }

}
