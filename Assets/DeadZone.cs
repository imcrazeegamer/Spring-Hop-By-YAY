using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            //Dead
            collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            Debug.Log("Dead");
        }
    }
}
