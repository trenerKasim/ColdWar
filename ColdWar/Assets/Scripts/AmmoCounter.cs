﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum magazineType {_3x4_Stick, _3_Clip };
public class AmmoCounter : MonoBehaviour
{
    public Image image;

    public TextMeshProUGUI magazinesLeft;

    public magazineType magazineType;
    public string slot;

    public Sprite[] _3x4_StickSprites;
    public Sprite[] _3_ClipSprites;

    public void typeSwitch(magazineType newType)
    {
        magazineType = newType;
    }

    public void updateCounter(Unit activeUnit)
    {
        switch (magazineType)
        {
            case magazineType._3x4_Stick : _3x4_StickShow(activeUnit); break;
            case magazineType._3_Clip: _3_ClipShow(activeUnit); break;
        }
        magazinesLeft.text = activeUnit.mainWeaponMagazines.ToString();
    }

    void _3x4_StickShow(Unit unit)
    {
        if (slot == "main")
        {
            switch (unit.mainWeaponAmmo)
            {
                case 12: image.sprite = _3x4_StickSprites[4]; break;
                case 9: image.sprite = _3x4_StickSprites[3]; break;
                case 6: image.sprite = _3x4_StickSprites[2]; break;
                case 3: image.sprite = _3x4_StickSprites[1]; break;
                case 0: image.sprite = _3x4_StickSprites[0]; break;
            }
        }
    }

    void _3_ClipShow(Unit unit)
    {
        if (slot == "main")
        {
            switch (unit.mainWeaponAmmo)
            {
                case 3: image.sprite = _3_ClipSprites[3]; break;
                case 2: image.sprite = _3_ClipSprites[2]; break;
                case 1: image.sprite = _3_ClipSprites[1]; break;
                case 0: image.sprite = _3_ClipSprites[0]; break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}