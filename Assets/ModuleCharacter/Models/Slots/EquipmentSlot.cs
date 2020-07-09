using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EquipmentSlot : MonoBehaviour
{
    /// <summary>
    /// TBD
    /// </summary>
    public int sortRank = 0;
    public Equipment Equipment;

    public virtual Sprite GetIcon()
    {
        if (Equipment == null)
        {
            Debug.LogError("I dont know what to do here");
            return null;
        }

        return Equipment.Icon;
    }

}