using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GCharacter
{
     

  public GCharacter_SO blueprint;

  public string name;
  public int currentHp;
  public int maxHp;
  public GClass gClass;
  public Sprite icon;
  // public int MainHandSlots;
  // public int OffHandSlots;
  // public int TorsoSlots;

  public List<Equipment> EquipmentSet;
  public List<EquipmentSlot> EquipmentSlotSet;
  public List<EquipmentSlot_SO> EquipmentSlotEsOhSet;

  void awake()
  {
    Debug.Log("initializing new character");
    //TODO drive slots based off fields
    EquipmentSlotSet.Add(new MainHandSlot());
    // EquipmentSlotSet.Add(new MainHandSlot());

  }





}

