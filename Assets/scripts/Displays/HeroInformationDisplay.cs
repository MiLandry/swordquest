using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroInformationDisplay : MonoBehaviour
{
    public Party_SO party;

    //public Image icon;
    public new Text name;


    private void Start()
    {
        name.text = party.name;
    }




}