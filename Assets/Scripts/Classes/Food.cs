using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "Food")]
public class Food : ScriptableObject
{
    [SerializeField]
    private int id;

    [SerializeField]
    private string displayName;

    [SerializeField]
    [TextArea(1, 5)]
    private string description;

    [SerializeField]
    private int price; //sold price

    [SerializeField]
    private List<RecipeItems> recipe = new List<RecipeItems>();
}

[System.Serializable]
public class RecipeItems
{
    [SerializeField]
    private Ingredient ingredient;

    [SerializeField]
    private int amount;
}
