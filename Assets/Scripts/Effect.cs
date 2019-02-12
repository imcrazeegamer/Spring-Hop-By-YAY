﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New Effect", menuName = "Items/Effect")]
public class Effect : ScriptableObject
{
    public enum Function { Rust, Shield, PowerSpring }

    public new string name;

    private GameObject ShieldPowerUp;

    public GameObject prefab;

    private static bool shield = false;

    private AudioSource audi;

    public Function function;

    void Initialize()
    {
        ShieldPowerUp = GameObject.FindGameObjectWithTag("Shield");
    }

    void ShieldEnable()
    {
        ShieldPowerUp.GetComponent<SpriteRenderer>().enabled = true;
        shield = true;
    }


    void ShieldDisable()
    {
        ShieldPowerUp.GetComponent<SpriteRenderer>().enabled = false;
        shield = false;
    }


    public IEnumerator Rust(Player player, GameObject buffitem)
    {
        Initialize();
        Debug.Log(shield);
        if (shield)
        {
            ShieldDisable();
            Debug.Log("invicstart");
            yield return new WaitForSeconds(2);
            Debug.Log("invincibleover");
        }
        else
        {
            //config
            const float duration = 3.5f;

            Rigidbody2D rb = player.rb;


            //do rust effect
            rb.gravityScale *= 1.17f;

            //return null;
            buffitem.GetComponent<AudioSource>().Play();
            buffitem.GetComponent<SpriteRenderer>().enabled = false;
            buffitem.GetComponent<BoxCollider2D>().enabled = false;
            //Debug.Log(rb.gravityScale);
            yield return new WaitForSeconds(duration);
            //Debug.Log("wait is over");
            rb.gravityScale = player.GravityScale;
            Destroy(buffitem);
        }
    }

    public IEnumerator PowerSpring(Player player, GameObject buffitem)
    {
        Initialize();
        //config
        const float duration = 2f;

        //do rust effect


        float tempJumpForce = 0;
        foreach (Platform platform in GameObject.FindGameObjectsWithTag("Platform").Select((p) => p.GetComponent<Platform>()))
        {
            tempJumpForce = platform.jumpForce;
            platform.jumpForce *= 1.5f;
        }
        //return null;
        buffitem.GetComponent<AudioSource>().Play();
        buffitem.GetComponent<SpriteRenderer>().enabled = false;
        buffitem.GetComponent<BoxCollider2D>().enabled = false;
        //Debug.Log(rb.gravityScale);
        yield return new WaitForSeconds(duration);
        //Debug.Log("wait is over");
        foreach (Platform platform in GameObject.FindGameObjectsWithTag("Platform").Select((p) => p.GetComponent<Platform>()))
        {
            platform.jumpForce = tempJumpForce;
        }
        Destroy(buffitem);


        //disable effect and remove debuff
    }

    public IEnumerator Sheild(Player player, GameObject buffitem)
    {
        Initialize();
        Debug.Log(ShieldPowerUp);
        ShieldEnable();
        buffitem.GetComponent<AudioSource>().Play();
        buffitem.GetComponent<SpriteRenderer>().enabled = false;
        buffitem.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("Enableshield" + shield);

        yield return new WaitForSeconds(5);

        ShieldDisable();
        Debug.Log("shielddisable");
        Destroy(buffitem);

    }
}

