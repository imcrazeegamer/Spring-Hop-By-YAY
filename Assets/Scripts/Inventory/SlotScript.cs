using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlotScript : MonoBehaviour
{
    public Item item;
    [HideInInspector]
    public bool Equipped;


    // Start is called before the first frame update
    void Start()
    {
        
        Image img = GetComponentsInChildren<Image>()[1];
        Debug.Log(img);

        img.sprite = item.Icon;
        GetComponent<Button>().onClick.AddListener(() => btnClick());
    }
    void btnClick()
    {
        Text Txt = GetComponentInChildren<Text>();
        if (!Equipped)
        {
            InventoryComponent.MyInstance.inventory.Equip(item);
            Txt.text = "Unequip Item";
        }
        else
        {
            InventoryComponent.MyInstance.inventory.Unequip(item);
            Txt.text = "Equip Item";
        }
        Equipped = !Equipped;
        
    }
}
