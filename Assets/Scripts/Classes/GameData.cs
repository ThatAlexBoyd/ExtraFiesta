using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    public List<City> CityList { get => cityList;}

    [SerializeField] private List<City> cityList = new List<City>();
}
