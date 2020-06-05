using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "NewClass", menuName = "GClass_SO")]
public class GClass_SO : ScriptableObject
{
    public new string name;
    //public int hp;

}

//public float Cooldown;

//public float Range;
//public float minDamage;
//public float maxDamage;
//public float criticalMultiplier;
//public float criticalChance;

//    public Attack CreateAttack(CharacterStats wielderStats, CharacterStats defenderStats)
//    {
//        float coreDamage = wielderStats.characterDefinition.baseDamage;
//        coreDamage += Random.Range(minDamage, maxDamage);

//        bool isCritical = Random.value < criticalChance;
//        if (isCritical)
//            coreDamage *= criticalMultiplier;

//        if (defenderStats != null)
//            coreDamage -= defenderStats.GetResistance();

//        return new Attack((int)coreDamage, isCritical);
//    }
//}
