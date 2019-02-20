using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hat",menuName ="Items/Hat")]
public class Hat : Item
{
    [SerializeField]
    private readonly float playerdist;

    public void init()
    {
        
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        pos.y += playerdist;
        Instantiate(this.Prefab, pos, Quaternion.identity);
    }
}
