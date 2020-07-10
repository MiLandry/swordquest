using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new item", menuName = "Item_SO")]
public class Item_SO : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public int Tier;
}
