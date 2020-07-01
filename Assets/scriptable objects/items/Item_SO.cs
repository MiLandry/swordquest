using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Items are safe, they don"t contain objects i think, and they would only be read
public class Item_SO : ScriptableObject
{
    public new string name;
    public Sprite icon;
    public int tier;
}
