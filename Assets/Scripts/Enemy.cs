using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float ffffforce = 50000.0f;
    //Amount of Degress to Add to the angle of the KnockBack
    [SerializeField]
    private float arcAditive = 40;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector2 dir = collision.contacts[0].point - (Vector2)transform.position;
            dir = dir.normalized;
            Vector2 velocity = new Vector2();
            float angle = Mathf.Atan2(dir.y, dir.x) * (180 / Mathf.PI);
            Debug.Log("Angle = " + angle);

            if (Mathf.Abs(angle) - 100 <= 45) 
            {
                dir = new Vector2(dir.x + Mathf.Cos(arcAditive * (Mathf.PI / 180)) * Mathf.Sign(angle), dir.y + Mathf.Sin(arcAditive * (Mathf.PI / 180)) * Mathf.Sign(angle));
                Debug.Log("Angle + " + arcAditive + "Deg = " + dir);
            }


            velocity = dir * ffffforce;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(velocity);
            //Debug.Log(velocity);
            
        }
    }
}
