using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shop", menuName = "Shop")]
public class Shop : Marker
{
    [SerializeField] private IngredientIntDictionary shopInventory;
    //price variation (region?)
    //restocking timer
}

[System.Serializable]
public class IngredientIntDictionary:UDictionary<Ingredient,int> { } //subclass for dictionary to show in editor