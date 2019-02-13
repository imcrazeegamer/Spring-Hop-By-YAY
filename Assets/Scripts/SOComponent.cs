using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOComponent : MonoBehaviour
{
    public Effect SObject;
    
    public void FuncHandle(Player player)
    {
        
        switch (SObject.function)
        {
            
            case Effect.Function.Rust:
                StartCoroutine(SObject.Rust(player, this.gameObject));
                return;
            case Effect.Function.PowerSpring:
                StartCoroutine(SObject.PowerSpring(player, this.gameObject));
                return;
            case Effect.Function.Shield:
                StartCoroutine(SObject.Sheild(player, this.gameObject));
                return;
            case Effect.Function.Cape:
                StartCoroutine(SObject.Cape(player, this.gameObject));
                return;
            default:
                return;
        }
    }
}
