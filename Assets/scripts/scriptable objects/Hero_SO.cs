using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "NewHero", menuName = "Hero_SO")]
public class Hero_SO : ScriptableObject
{
    public new string name;
    public int hp;
    public GClass_SO gClass;
    public Sprite icon;

}

