using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Party
{
    public List<GCharacter> gCharacters;

    public Sprite icon;
    public string partyName;
    public List<Item> inventory;

}
