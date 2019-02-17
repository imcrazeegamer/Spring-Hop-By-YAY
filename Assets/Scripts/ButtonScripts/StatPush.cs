using System.Collections;
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


    //General Store Images
    [SerializeField]
    private Sprite OffSprite;

    [SerializeField]
    private Sprite OnSprite;

    [SerializeField]
    private Image StoreImage;


    private void Start()
    {
        jumpBoost.SetActive(false);
        speedBoost.SetActive(false);
        backtoStore.SetActive(false);
        shieldButton.SetActive(false);
        springButton.SetActive(false);
        capeButton.SetActive(false);
        backFromPower.SetActive(false);
    }

    public void OnClick()
    {
        Back.SetActive(!Back.activeSelf);
        Stat.SetActive(!Stat.activeSelf);
        Power.SetActive(!Power.activeSelf);
        Hat.SetActive(!Hat.activeSelf);
        jumpBoost.SetActive(!jumpBoost.activeSelf);
        speedBoost.SetActive(!speedBoost.activeSelf);
        backtoStore.SetActive(!backtoStore.activeSelf);

        if (StoreImage.sprite == OnSprite)
            StoreImage.sprite = OffSprite;
        else
        {
            StoreImage.sprite = OnSprite;
        }
    }

    public void onClickPower()
    {
        Back.SetActive(!Back.activeSelf);
        Stat.SetActive(!Stat.activeSelf);
        Power.SetActive(!Power.activeSelf);
        Hat.SetActive(!Hat.activeSelf);
        shieldButton.SetActive(!shieldButton.activeSelf);
        springButton.SetActive(!springButton.activeSelf);
        capeButton.SetActive(!capeButton.activeSelf);
        backFromPower.SetActive(!backFromPower.activeSelf);

        if (StoreImage.sprite == OnSprite)
            StoreImage.sprite = OffSprite;
        else
        {
            StoreImage.sprite = OnSprite;

        }
    }
}


 