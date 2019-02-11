using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffHandler : MonoBehaviour
{
    Player player;
    GameObject collided;
    private void Start()
    {
        player = GetComponent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collided = collision.gameObject;
        SOComponent buff = collided.GetComponent<SOComponent>();
        if (buff != null)
        {
            //print(buff);
            buff.FuncHandle(player);
        }
    }
}
