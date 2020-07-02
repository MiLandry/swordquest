using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultData : MonoBehaviour
{

    public GCharacter GCharacter;

    //public List<Item> Inventory;

    //public List<Equipment> EquipmentSet;

    void Awake()
    {
        Debug.Log("initializing default data");
        GCharacter = new GCharacter();
        GCharacter.name = "testyboi";
        GCharacter.currentHp =  2;
        GCharacter.maxHp = 10;
        GCharacter.gClass = new GClass();
        GCharacter.gClass.name = "fighter";

    }

    // Update is called once per frame
    void Update()
    {

    }
}
