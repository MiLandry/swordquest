using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultData : MonoBehaviour
{

    public List<GCharacter> PartyMembers;
    public string PartyName;
    public GCharacter GCharacter;

    //public List<Item> Inventory;

    //public List<Equipment> EquipmentSet;

    void Awake()
    {
        Debug.Log("initializing default data");


    }

    // Update is called once per frame
    void Update()
    {

    }
}
