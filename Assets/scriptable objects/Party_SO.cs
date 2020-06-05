using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewParty", menuName = "Party_SO")]
public class Party_SO : ScriptableObject
{
    public List<GCharacter_SO> gCharacters;
    //[SerializeField]
    public Sprite theSprite;
    public string partyName;
    public List<Item_SO> inventory;

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
