using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : ScriptableObject
{
    [SerializeField]
    private int id;

    [SerializeField]
    private string displayName;

    [SerializeField]
    [TextArea(1, 5)]
    private string description;

    public string DisplayName { get => displayName;}
}
