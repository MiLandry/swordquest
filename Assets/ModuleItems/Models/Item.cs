using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public Item()
    {
        
    }
    public Item(Item_SO blueprint)
    {
        Blueprint = blueprint;

    }   

    public string Name
    {get{return Blueprint.Name;}}
    public Sprite Icon
    {get{return Blueprint.Icon;}}
    public int Tier;
    public Item_SO Blueprint;

}
