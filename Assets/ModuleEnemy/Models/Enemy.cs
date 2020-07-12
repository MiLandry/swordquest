using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Enemy
{

  public Enemy_SO Blueprint;
  public string Id = Guid.NewGuid().ToString();

  public int currentHp;
  public string Name
  { get {return Blueprint.Name;} }

    public Sprite Icon
    { get {return Blueprint.Icon;}}




  //custom method for manual initialization/reset
  public void Initialize()
  {
    Debug.Log("Initializing()ing new Enemy" + Blueprint.Name);

  }


}

