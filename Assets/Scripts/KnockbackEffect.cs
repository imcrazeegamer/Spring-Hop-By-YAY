using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackEffect : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool knockBack;
    public float thrust;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (knockBack)
        {
            knockBack = !knockBack;
            rb.AddForce(transform.right * -thrust);
            rb.AddForce(transform.up * thrust);
        }
    }
}
