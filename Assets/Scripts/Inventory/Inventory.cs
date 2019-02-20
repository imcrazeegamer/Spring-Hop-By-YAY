using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Inventory", menuName = "Inventory")]
public class Inventory : ScriptableObject
{

    public List<Item> Items;

    private List<Item> Equipped;

    public void Equip(Item item)
    {
        Equipped.Add(item);
        Debug.Log(item + " Equiped");
    }
    public void Unequip(Item item)
    {

        if (Equipped.Contains(item))
        {
            Equipped.Remove(item);
            Debug.Log(item + " Unequiped");
        }
        else
        {
            Debug.Log(item + "Was Not Equiped");
        }
    }

}
