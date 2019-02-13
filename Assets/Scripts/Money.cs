using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Money", menuName = "Items/Money")]
public class Money : ScriptableObject
{
    public new string name;

    public int currencyAmount;

    public Sprite Artwork;

    private AudioSource audi;
    

    void Start()
    {
        //buffitem.GetComponent<AudioSource>().Play();
        //Sound needs to be played on pickup.
    }
}
