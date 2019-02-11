using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private Sprite image;
    private string name = "";

    public Sprite Image { get { return image; } set { image = value; } }

    public Item(Sprite image)
    {
        this.image = image;
    }

    public Item(string name, Sprite image)
    {
        this.name = name;
        this.image = image;
    }
    
}
