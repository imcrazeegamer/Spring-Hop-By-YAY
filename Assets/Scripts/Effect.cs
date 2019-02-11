using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New Effect", menuName = "Items/Effect")]
public class Effect : ScriptableObject
{
    public enum Function { Rust, Sheild, PowerSpring }

    public new string name;

    public Sprite Artwork;

    public Function function;

    public IEnumerator Rust(Player player, GameObject buffitem)
    {
        //config
        const float duration = 3.5f;

        Rigidbody2D rb = player.rb;
        

        //do rust effect
        rb.gravityScale *= 1.17f;

        //return null;
        buffitem.GetComponent<SpriteRenderer>().enabled = false;
        //Debug.Log(rb.gravityScale);
        yield return new WaitForSeconds(duration);
        //Debug.Log("wait is over");
        rb.gravityScale = player.GravityScale;
        Destroy(buffitem);
    }

    public IEnumerator PowerSpring(Player player, GameObject buffitem)
    {
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
        buffitem.GetComponent<SpriteRenderer>().enabled = false;
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
        //config
        const float duration = 5f;

        //do rust effect

        yield return new WaitForSeconds(duration);

        //disable effect and remove debuff
    }

}
