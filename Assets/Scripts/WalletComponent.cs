using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WalletComponent : MonoBehaviour
{
    public Wallet wallet;

    [SerializeField]
    private AudioSource audioo;

    private void Start()
    {
        Text ScoreText = GameObject.FindGameObjectWithTag("moneyScore").GetComponent<Text>();
        ScoreText.text = "Money: " + wallet.Balance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Money")
        {
            //GetComponent<AudioSource>().Play();
            //The wrong audio is being played for some reason.
            wallet.Balance += collision.gameObject.GetComponent<MoneyComponent>().money.currencyAmount;
            Text ScoreText = GameObject.FindGameObjectWithTag("moneyScore").GetComponent<Text>();
            ScoreText.text = "Money: " + wallet.Balance;
            Destroy(collision.gameObject);
        }
    }
}
