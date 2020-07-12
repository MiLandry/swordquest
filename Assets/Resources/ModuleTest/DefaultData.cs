using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultData : MonoBehaviour
{

    public List<GCharacter> PartyMembers;
    public string PartyName;
    public GCharacter GCharacter;
    public List<Item_SO> Inventory;


    void Awake()
    {
        Debug.Log("initializing default data");


    }

}
