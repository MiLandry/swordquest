using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultData : MonoBehaviour
{

    public List<GCharacter> PartyMembers;
    public string PartyName;
    public List<Item_SO> Inventory;
    public List<Enemy> Enemies;


    void Awake()
    {
        Debug.Log("initializing default data");


    }

}
