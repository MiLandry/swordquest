using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GCharacter
{
     

  public GCharacter_SO blueprint;

  public new string name;
  public int currentHp;
  public int maxHp;
  public GClass gClass;
  public Sprite icon;

  public List<Equipment> EquipmentSet;





}

