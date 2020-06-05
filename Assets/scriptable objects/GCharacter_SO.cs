﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "NewHero", menuName = "GCharacter_SO")]
public class GCharacter_SO : ScriptableObject
{
  public new string name;
  public int hp;
  public GClass_SO gClass;
  public Sprite icon;

  public List<Equipment> equipmentSet;


  // equipmentset
  // public ManualEquipment mainHand;
  // public ManualEquipment offHand;
  // public Equipment body;

  public void EquipItem(Equipment equipment)
  {

  }

}

