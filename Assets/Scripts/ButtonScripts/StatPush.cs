﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatPush : MonoBehaviour
{
    //General Store Buttons
    [SerializeField]
    private GameObject Back;

    [SerializeField]
    private GameObject Stat;

    [SerializeField]
    private GameObject Power;

    [SerializeField]
    private GameObject Hat;



    //Stat Boost Buttons
    [SerializeField]
    private GameObject jumpBoost;

    [SerializeField]
    private GameObject speedBoost;

    [SerializeField]
    private GameObject backtoStore;


    //PowerUp Buttons
    [SerializeField]
    private GameObject shieldButton;

    [SerializeField]
    private GameObject springButton;

    [SerializeField]
    private GameObject capeButton;

    [SerializeField]
    private GameObject backFromPower;


    //Hat Buttons
    [SerializeField]
    private GameObject gibus;

    [SerializeField]
    private GameObject crown;

    [SerializeField]
    private GameObject ash;

    [SerializeField]
    private GameObject cyclops;

    [SerializeField]
    private GameObject bravo;

    [SerializeField]
    private GameObject cloud;

    [SerializeField]
    private GameObject backFromHat;



    //Inventory Buttons
    [SerializeField]
    private GameObject inventoryOpen;

    [SerializeField]
    private GameObject backFromInventory;

    [SerializeField]
    private GameObject slot1;

    [SerializeField]
    private GameObject slot2;

    [SerializeField]
    private GameObject slot3;

    [SerializeField]
    private GameObject slot4;

    [SerializeField]
    private GameObject slot5;

    [SerializeField]
    private GameObject slot6;

    [SerializeField]
    private GameObject slot7;

    [SerializeField]
    private GameObject slot8;

    [SerializeField]
    private GameObject slot9;

    [SerializeField]
    private GameObject slot10;

    [SerializeField]
    private GameObject slot11;

    [SerializeField]
    private GameObject slot12;

    private void Start()
    {
        
        jumpBoost.SetActive(!jumpBoost.activeSelf);
        speedBoost.SetActive(!speedBoost.activeSelf);
        backtoStore.SetActive(!backtoStore.activeSelf);
        shieldButton.SetActive(!shieldButton.activeSelf);
        springButton.SetActive(!springButton.activeSelf);
        capeButton.SetActive(!capeButton.activeSelf);
        backFromPower.SetActive(!backFromPower.activeSelf);
        gibus.SetActive(!gibus.activeSelf);
        crown.SetActive(!crown.activeSelf);
        ash.SetActive(!ash.activeSelf);
        cyclops.SetActive(!cyclops.activeSelf);
        bravo.SetActive(!bravo.activeSelf);
        cloud.SetActive(!cloud.activeSelf);
        backFromHat.SetActive(!backFromHat.activeSelf);
        backFromInventory.SetActive(!backFromInventory.activeSelf);
        slot1.SetActive(!slot1.activeSelf);
        slot2.SetActive(!slot2.activeSelf);
        slot3.SetActive(!slot3.activeSelf);
        slot4.SetActive(!slot4.activeSelf);
        slot5.SetActive(!slot5.activeSelf);
        slot6.SetActive(!slot6.activeSelf);
        slot7.SetActive(!slot7.activeSelf);
        slot8.SetActive(!slot8.activeSelf);
        slot9.SetActive(!slot9.activeSelf);
        slot10.SetActive(!slot10.activeSelf);
        slot11.SetActive(!slot11.activeSelf);
        slot12.SetActive(!slot12.activeSelf);
    }
}


 