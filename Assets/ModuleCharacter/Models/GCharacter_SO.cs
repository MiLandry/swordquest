using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewHero", menuName = "GCharacter_SO")]
public class GCharacter_SO : ScriptableObject, ISerializationCallbackReceiver
{

  public string InitialName;
  public int InitialStartingHp;
  public GClass InitialGClass;
  public Sprite Icon;
  public List<EquipmentSlot> StartingEquipmentSlotSet;

  // public List<Equipment> initialEquipmentSet;



//   public new string name;
//   public int hp;
//   public GClass_SO gClass;
//   public Sprite icon;

  // public List<Equipment> equipmentSet;

     public void OnBeforeSerialize()
     {

     }

     public void OnAfterDeserialize()
     {
;
            // name = initialName;
            // hp = initialHp;
            // gClass = initialGClass;
            // icon = initialIcon;

     }



}

