using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHandSlot : EquipmentSlot
{
    public override Sprite GetIcon()
    {
        if (Equipment == null)
        {
            Debug.Log("loading empty hand icon");
            return null;
        }

        return Equipment.Icon;
    }

}