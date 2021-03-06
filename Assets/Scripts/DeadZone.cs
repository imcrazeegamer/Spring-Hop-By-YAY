﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public AudioSource death;
    public AudioClip deaths;
    public GameObject RestartButton;
    public GameObject MenuButton;

    private void Start()
    {
        RestartButton.SetActive(false);
        MenuButton.SetActive(false);
    }
    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            //Dead
            death.clip = deaths;
            death.Play();
            collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            //Debug.Log("Dead");
            yield return new WaitForSeconds(1.5f);
            RestartButton.SetActive(true);
            MenuButton.SetActive(true);
        }
        else if (collision.gameObject.tag == "Effect" || collision.gameObject.tag == "ShieldPower" || collision.gameObject.tag == "Money")
        {
            Destroy(collision.gameObject);
            //I'm not sure why, but nothing's getting destroyed for some reason. Some platforms are also not getting destroyed.
        }
 }
    }

