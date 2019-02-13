using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsBuy : MonoBehaviour
{

    private bool springBought;

    private bool capeBought;

    private bool shieldBought;

    private bool jumpIncrease;

    private bool speedIncrease;

    private bool gibusBuy;

    private bool crownBuy;

    private bool ashBuy;

    private bool cyclopsBuy;

    private bool johnnyBuy;

    private bool cloudBuy;


    public void ToggleAnalog()
    {
        //The idea is to use an 'if'statement to check Hopper's current money, subtract the required amount if Hopper has enough, then change a bool over in the Player script so Hopper 
        //starts with said powerup, then changing the bool back to false after it's finished. Issue is accessing all these other scripts.

        //The same idea applies to stat boosts and hats, though those bools won't get set back to false afterwards.

        //Probably going to have to add a system checking which hat Hopper has selected, as well as making sure he owns said hat obviously.
    }
}
