using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Ingredient")]
public class Ingredient : ScriptableObject
{
    [SerializeField]
    private int id;

    [SerializeField]
    private string displayName;

    [SerializeField]
    [TextArea(1, 5)]
    private string description;

    [SerializeField]
    private int cost;

    [SerializeField]
    private int quantity;
}
