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
        Shield.SetActive(false);
        //collectedmoney.text = PlayerPrefs.GetInt("collectedmoney", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
       
    }
 
}



