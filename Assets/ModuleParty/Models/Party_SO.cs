using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewParty", menuName = "Party_SO")]
public class Party_SO : ScriptableObject
{
    public List<GCharacter_SO> gCharacters;
    //[SerializeField]
    public Sprite theSprite;
    public string partyName;
    public List<Item_SO> inventory;

}
