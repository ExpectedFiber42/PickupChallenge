using UnityEngine;
using System.Collections;

public class Coin : Pickup//inherit van pickup
{
    //private float m_score = 0;

    //override = je maakt een extensie van die functie
    public override void PlayerHit(Player _GO)
    {
        _GO.m_score += 1;
        //Debug.Log(m_score);
        base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
        //voeg hier code toe zo dat de speler zijn score omhoog gaat
    }
}
