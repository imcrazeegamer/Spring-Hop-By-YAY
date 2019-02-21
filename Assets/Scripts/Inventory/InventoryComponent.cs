using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryComponent : MonoBehaviour
{
    private static InventoryComponent instance;

    public static InventoryComponent MyInstance { get { if (instance == null) { instance = FindObjectOfType<InventoryComponent>(); } return instance; } }

    [SerializeField]
    private GameObject slotPrefab;

    public Inventory inventory;
    
    public void Awake()
    {
        // Draw Inverntory to Screen
        //int slotSize = inventory.Items.Count;\
        Debug.Log("Inventory Size: " + inventory.Items.Count);
        if(inventory.Items.Count == 0)
        {
            GameObject Text = new GameObject("TextOBJ");
            Instantiate(Text, gameObject.transform.parent);
            Text t = Text.AddComponent<Text>();
            t.text = "Why would you try to access your inventory while its empty???";
            t.fontSize = 69;
            return;
        }
        foreach (Item item in inventory.Items)
        {
            Debug.Log(item);
            Debug.Log(slotPrefab.GetComponent<SlotScript>());
            slotPrefab.GetComponent<SlotScript>().item = item;
            Instantiate(slotPrefab, transform);
        }
    }

}
