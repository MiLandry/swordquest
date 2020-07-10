using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffHandSlot : EquipmentSlot
{
        public override Sprite GetIcon()
    {
        if (Equipment == null)
        {
            Debug.Log("loading empty shield icon");
            return Resources.Load<Sprite>("Icons/EmptyShield");
        }

        return Equipment.Icon;
    }

}