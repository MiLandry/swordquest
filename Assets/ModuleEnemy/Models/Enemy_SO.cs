using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewEnemy", menuName = "Enemy_SO")]
public class Enemy_SO : ScriptableObject
{

  public string Name;
  public int InitialStartingHp;
  public Sprite Icon;


}

