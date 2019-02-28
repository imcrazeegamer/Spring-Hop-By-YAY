using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed = 10f;

    [SerializeField]
    private readonly AudioSource PowerupSoundSource;
    [SerializeField]
    private readonly AudioClip PowerupSound;
    [SerializeField]
    private readonly AudioSource EnemyHitSoundSource;
    [SerializeField]
    private readonly AudioClip DamageSound;

    [SerializeField]
    private GameObject Shield;

    float screenWidth;

    [HideInInspector]
    public Rigidbody2D rb;

    float movement = 0f;

    // const
    public float GravityScale;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GravityScale = rb.gravityScale;
        float playerWidth = transform.localScale.x + 0.5f;
        screenWidth = Camera.main.aspect * Camera.main.orthographicSize + playerWidth;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        if(transform.position.x < -screenWidth)
        {
            transform.position = new Vector2(screenWidth, transform.position.y);
        }

        if (transform.position.x > screenWidth)
        {
            transform.position = new Vector2(-screenWidth, transform.position.y);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
       
    }
 
}



