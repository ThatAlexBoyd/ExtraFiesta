using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "City", menuName = "City")]
public class City : Marker
{
    [SerializeField] private List<Marker> locations = new List<Marker>();
    public List<Marker> Locations { get => locations; }
}
