using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed = 10f;

    public AudioSource powerup;
    public AudioClip power;
    public AudioSource enemyhit;
    public AudioClip damage;
    public GameObject RestartButton;
    public GameObject MenuButton;
    public GameObject Shield;

    private Text collectedmoney;
    public int currentMoney;

    // public float knockBack;
    //public float knockBackCount;
    //public float knockBackLength;
    // public bool knockFromRight;

    //private float thrust = 10.0f;

    bool hit;
    bool ShieldActive;
    Rigidbody2D rb;

    float movement = 0f;

    // Use this for initialization
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
        Shield.SetActive(false);
        collectedmoney.text = PlayerPrefs.GetInt("collectedmoney", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        //if (knockBackCount <= 0)
        //{
            Vector2 velocity = rb.velocity;
            velocity.x = movement;
            rb.velocity = velocity;
       /* }
        else
        {
            if (knockFromRight)
            {
                rb.velocity﻿ = new Vector2(-knockBack, knockBack);
            }
            if (!knockFromRight)
            {
                rb.velocity﻿ = new Vector2(knockBack, knockBack);
            }
            knockBackCount -= Time.deltaTime;
        }*/
    }
    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
       /* if (collision.gameObject.CompareTag("Enemy") && !ShieldActive)
        {
            collision.gameObject.SetActive(false);
            rb.AddForce(transform.up * thrust);
            */
            if (collision.gameObject.CompareTag("Rust") && !ShieldActive)
            {
            enemyhit.clip = damage;
            enemyhit.Play();
            collision.gameObject.SetActive(false);
                movementSpeed = 5f;
                yield return new WaitForSeconds(5);
                movementSpeed = 10f;
                //Not exactly sure on what to type to make a reference to another script. Feel like it's obvious, but I can't figure it out...
            }

            if (collision.gameObject.CompareTag("SuperJump"))
            {
            powerup.clip = power;
            powerup.Play();
                collision.gameObject.SetActive(false);
                movementSpeed = 20f;
                yield return new WaitForSeconds(5);
                movementSpeed = 10f;
            }

            if (collision.gameObject.CompareTag("ShieldPower"))
            {
            powerup.clip = power;
            powerup.Play();
            collision.gameObject.SetActive(false);
                Shield.SetActive(true);
                Shield.SetActive(true);
                yield return new WaitForSeconds(5);
                Shield.SetActive(false);
            Shield.SetActive(false);
                //This is probably really simple, but I couldn't figure out the exact method of turning the shield on and off when Hopper picks up the powerup.
            }

            if (collision.gameObject.CompareTag("Money"))
        {
            collision.gameObject.SetActive(false);
            currentMoney += 100;
            collectedmoney.text = PlayerPrefs.GetInt("collectedmoney", ++currentMoney).ToString();
        }
        }//All of these enemies and powerups still need to be spawned in randomly throughout the level. Wasn't sure I wanted to start messing with that.
         //The jetpack also needs to be coded, though I wasn't completely sure on where to start with that one.*/

    }



