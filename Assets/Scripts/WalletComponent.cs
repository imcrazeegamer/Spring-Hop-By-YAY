using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WalletComponent : MonoBehaviour
{
    public Wallet wallet;
    private void Start()
    {
        Text ScoreText = GameObject.FindGameObjectWithTag("moneyScore").GetComponent<Text>();
        ScoreText.text = "Moneyz: " + wallet.Balance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Money")
        {
            wallet.Balance += collision.gameObject.GetComponent<MoneyComponent>().money.currencyAmount;
            Text ScoreText = GameObject.FindGameObjectWithTag("moneyScore").GetComponent<Text>();
            ScoreText.text = "Moneyz: " + wallet.Balance;
            Destroy(collision.gameObject);
        }
    }
}
