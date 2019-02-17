using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WalletComponent : MonoBehaviour
{
    public Wallet wallet;

    private AudioSource audioo;

    private void Start()
    {
        Text ScoreText = GameObject.FindGameObjectWithTag("moneyScore").GetComponent<Text>();
        ScoreText.text = "Current Money: " + wallet.Balance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Money")
        {
            //GetComponent<AudioSource>().Play();
            //Wrong sound is being played. Need cash sound to play.
            wallet.Balance += collision.gameObject.GetComponent<MoneyComponent>().money.currencyAmount;
            Text ScoreText = GameObject.FindGameObjectWithTag("moneyScore").GetComponent<Text>();
            ScoreText.text = "Current Money: " + wallet.Balance;
            Destroy(collision.gameObject);
        }
    }
}
