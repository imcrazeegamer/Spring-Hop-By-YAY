using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject DestObj;

    private Vector3 dest;
    // Start is called before the first frame update
    void Start()
    {
        dest = DestObj.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log(dest + "" + collision.gameObject.transform.position);
            Vector3 playerpos = collision.gameObject.transform.position;
            collision.gameObject.transform.position = new Vector3(dest.x,playerpos.y,playerpos.z);
        }
    }
}
