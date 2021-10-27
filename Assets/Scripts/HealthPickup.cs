using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;
    public float healthBonus = 15f;
    public bool canCollect;
   

    private void Awake()
    {
        canCollect = true;
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerHealth.currentHealth < playerHealth.maxHealth && canCollect)
        {
            canCollect = false;
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthBonus;
            
            //Score.instance.displayScore += 10;
            Score.instance.AddPoint();
            Score.instance.AddCollected();
            PlayerHealth.instance.PickupSound();
            //Debug.Log("kerätty");
            

        }
    }
}
