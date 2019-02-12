using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{

         public Sprite newSprite;
 
    void yes()
    {
this.transform.GetComponent<UnityEngine.UI.Image>().sprite = newSprite;
    }
 

}
