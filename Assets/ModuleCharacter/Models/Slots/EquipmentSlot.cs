using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EquipmentSlot
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
            return Resources.Load<Sprite>("Icons/Error");
        }

        return Equipment.Icon;
    }

        public virtual string GetName()
    {
        if (Equipment == null)
        {
            Debug.LogError("I dont know what to do here");
            return "Error";
        }

        return Equipment.Name;
    }

    

}