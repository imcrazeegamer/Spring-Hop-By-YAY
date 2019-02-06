using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    [SerializeField]
	private float movementSpeed = 10f;


    bool hit;
    bool ShieldActive;
	Rigidbody2D rb;

	float movement = 0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;

        if (hit)
        {
          //Not sure if it's possible to detect collisions inside of FixedUpdate, but I couldn't figure it out. Ran into a number of roadblocks and couldn't quite figure
          //out how to detect collision and apply the proper force.
        }
	}
    IEnumerator OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy") && !ShieldActive)
            {
                hit = true;
                //Since Hopper will get knocked back, FixedUpdate seems like the best place to execute that part of the function.
            }

            if (collision.gameObject.CompareTag("Rust") && !ShieldActive)
            {
                collision.gameObject.SetActive(false);
                movementSpeed = 5f;
                yield return new WaitForSeconds(5);
                movementSpeed = 10f;
            //I think we should split jump height and movement speed into two seperate things. After hitting Rust, jumps become impossible. Players will sit on the current pickle and wait.
            //...or it's probably something to do with the platforms themselves that I can't figure out...
            }

            if(collision.gameObject.CompareTag("SuperJump"))
            {
             collision.gameObject.SetActive(false);
             movementSpeed = 20f;
             yield return new WaitForSeconds(5);
             movementSpeed = 10f;
            }

        if (collision.gameObject.CompareTag("ShieldPower"))
        {
            collision.gameObject.SetActive(false);
            ShieldActive = true;
            yield return new WaitForSeconds(5);
            ShieldActive = false;
            //This is probably really simple, but I couldn't figure out the exact method of turning the shield on and off when Hopper picks up the powerup.
        }
    }//All of these enemies and powerups still need to be spawned in randomly throughout the level. Wasn't sure I wanted to start messing with that.
    //The jetpack also needs to be coded, though I wasn't completely sure on where to start with that one.

}
