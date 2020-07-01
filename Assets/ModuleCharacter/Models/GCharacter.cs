using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GCharacter
{
     



  public new string name;
  public int currentHp;
  public int maxHp;
  public GClass gClass;
  public Sprite icon;

  public List<Equipment> equipmentSet;

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

