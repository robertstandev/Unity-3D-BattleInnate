using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStatsModifier : MonoBehaviour , IStatsModifier
{
    [SerializeField]private int healthToAdd = 25;
    
    public void addToCharacter(GameObject player)
    {
        player.GetComponent<Health>()?.addHealth(healthToAdd);
    }
}
