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

  public List<Equipment_SO> StartingEquipment;
  public List<EquipmentSlot> EquipmentSlotSet;



  //custom method for manual initialization/reset
  public void Initialize()
  {
    Debug.Log("Initializing()ing new character" + name);
    //TODO drive slots based off fields
    //EquipmentSlotSet.Add(new MainHandSlot());
    EquipmentSlotSet.Add(new MainHandSlot());
    EquipmentSlotSet.Add(new OffHandSlot());
    
    foreach (Equipment_SO equipment_SO in StartingEquipment)
    {
      Equipment equipment = new Equipment(equipment_SO);
      Equip(equipment);
    }
  }

  public void Equip(Equipment equipment)
  {
    Debug.Log("equipping a thing" + equipment);
    EquipmentSlotSet[0].Equipment = equipment;

  }





}

