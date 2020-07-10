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
            return Resources.Load<Sprite>("Icons/Hand");
        }

        return Equipment.Icon;
    }

    //  public override string GetName()
    // {
    //     if (Equipment == null)
    //     {
    //         Debug.Log("loading empty hand icon");
    //         return Resources.Load<Sprite>("Icons/Hand");
    //     }

    //     return Equipment.Icon;
    // }

}  