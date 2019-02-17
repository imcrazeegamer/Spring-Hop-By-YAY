using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{
    [SerializeField]
    private WalletComponent wallet;

    [SerializeField]
    private int currentMoney;

    [SerializeField]
    private Text currentShow;

    public bool hasBought;

    void Start()
    {
        currentMoney = wallet.wallet.Balance;

        Text ScoreText = GameObject.FindGameObjectWithTag("storeMoney").GetComponent<Text>();
        ScoreText.text = "Current Money: " + wallet.wallet.Balance;
    }

    public void OnClick()
    {
        if (wallet.wallet.Balance >= 2000 && !hasBought)
        {
        wallet.wallet.Balance -= 2000;
        currentMoney = wallet.wallet.Balance;
        Text ScoreText = GameObject.FindGameObjectWithTag("storeMoney").GetComponent<Text>();
        ScoreText.text = "Current Money: " + wallet.wallet.Balance;
            hasBought = true;
            //Needs to activate a bool in the platform script
        }
       else
        {
           //play error sound
        }
    }
}
