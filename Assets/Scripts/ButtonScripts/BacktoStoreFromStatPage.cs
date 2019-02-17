using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BacktoStoreFromStatPage : MonoBehaviour
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

    [SerializeField]
    private GameObject jumpBoost;

    [SerializeField]
    private GameObject speedBoost;

    [SerializeField]
    private GameObject backtoStore;

    [SerializeField]
    private bool isOn = false;


    //General Store Images
    [SerializeField]
    private Sprite OffSprite;

    [SerializeField]
    private Sprite OnSprite;

    [SerializeField]
    private Image StoreImage;


    public void OnClick()
    {
        if (isOn)
        {
            Back.SetActive(true); isOn = false;
            Stat.SetActive(true);
            Power.SetActive(true);
            Hat.SetActive(true);
            jumpBoost.SetActive(false);
            speedBoost.SetActive(false);
            backtoStore.SetActive(false);
        }
        else
        {
            Back.SetActive(false); isOn = true;
            Stat.SetActive(false);
            Power.SetActive(false);
            Hat.SetActive(false);
            jumpBoost.SetActive(true);
            speedBoost.SetActive(true);
            backtoStore.SetActive(true);
        }

        if (StoreImage.sprite == OnSprite)
            StoreImage.sprite = OffSprite;
        else
        {
            StoreImage.sprite = OnSprite;
        }
    }
}
