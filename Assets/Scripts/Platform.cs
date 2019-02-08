using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    
	public float jumpForce = 17f;

    public AudioSource jumping;
    public AudioClip jump;

    private bool hasScored = false;

	void OnCollisionEnter2D(Collision2D collision)
	{
        //ScoreManager score = new ScoreManager();


        //if obj is not coming from the bottom
        if (collision.relativeVelocity.y <= 0f)
        {
            if (!hasScored)
            {
                Score.scoring.PlatformScore(collision);
                hasScored = true;
            }
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
                jumping.clip = jump;
                jumping.Play();
                Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
                //I think something here might be the cause of Hopper sticking to walls like Spider-Man.
			}
		}
	}

}
