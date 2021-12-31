using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "City", menuName = "City")]
public class City : Location
{
    [SerializeField]
    private List<Location> locations = new List<Location>();
}
