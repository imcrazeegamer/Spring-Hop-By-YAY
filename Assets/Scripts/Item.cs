using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private new string name = "";
    [SerializeField]
    private GameObject prefab;

    public Sprite Icon { get { return icon; }}

    public GameObject Prefab { get { return prefab; } }

    public string Name { get { return name; } }
}
