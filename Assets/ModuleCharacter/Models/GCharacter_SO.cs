using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO : make it so that fields are reaadonly OR use initial pattern I found below... Or maybe just ignore?

[Serializable]
[CreateAssetMenu(fileName = "NewHero", menuName = "GCharacter_SO")]
public class GCharacter_SO : ScriptableObject, ISerializationCallbackReceiver
{

  public new string initialName;
  public int initialHp;
  public GClass_SO initialGClass;
  public Sprite initialIcon;

  // public List<Equipment> initialEquipmentSet;



  public new string name;
  public int hp;
  public GClass_SO gClass;
  public Sprite icon;

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

