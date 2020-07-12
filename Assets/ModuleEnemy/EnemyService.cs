using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class EnemyService : Singleton<EnemyService>
{
    Game game;

    // public string PartyName;
    public List<Enemy> Enemies;
    // public int IndexOfEditedGCharacter;

    // public string activeGCharacter;

    //only for testing/prototyping really
    // public GCharacter GCharacter;
    // public List<Equipment> EquipmentSet;
    // public List<Item> Inventory;



    override protected void Awake()
    {
        Debug.Log("Creating EnemyService...");
        base.Awake();
        game = UnityEngine.Object.FindObjectOfType<Game>();

        // InventoryItemDisplay.OnItemSelected += EquipItem;
        // EquipmentSlotDisplay.OnEquipmentClicked += ChangeEquipment;


    }
    void Start()
    {
        DefaultData defaultData = UnityEngine.Object.FindObjectOfType<DefaultData>();
        if (defaultData==null)
        {
            Debug.LogError(" Your default data prefab is broken and you are going to be sad.");
        }

        if (!Enemies.Any())
        {
            Enemies = defaultData.Enemies;
            // PartyMembers[0].Initialize();

            // TODo make this a loop
        }
    }


    override protected void OnDestroy()
    {
        // InventoryItemDisplay.OnItemSelected -= EquipItem;
        // EquipmentSlotDisplay.OnEquipmentClicked -= ChangeEquipment;
    }

    // end of boilerplate

}
