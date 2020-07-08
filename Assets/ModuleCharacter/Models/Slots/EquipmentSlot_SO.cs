using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new slot", menuName = "EquipmentSlot_SO")]
public class EquipmentSlot_SO : ScriptableObject
{
    /// <summary>
    /// TBD
    /// </summary>
    public int sortRank = 0;
    public Equipment Equipment;

}