using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item_SO
{
    /// <summary>
    /// When Rendering or sorting equipment, The equipment that has the highest
    /// rank will appear first.
    /// </summary>
    public int sortRank = 0;

}
