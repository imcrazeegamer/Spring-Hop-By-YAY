using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public AudioSource death;
    public AudioClip deaths;
    public GameObject RestartButton;
    public GameObject MenuButton;

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
            yield return new WaitForSeconds(3);
            RestartButton.SetActive(true);
            MenuButton.SetActive(true);
        }
 }
    }

