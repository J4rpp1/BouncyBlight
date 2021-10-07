using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    PlayerHealth playerHealth;
    public float healthLose = 100f;




    private void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHealth.currentHealth = playerHealth.currentHealth - healthLose;

    }

    private float secondsToDestroy = 2f;
    void Start()
    {
        StartCoroutine(DestroySelf());
    }

   
   

    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(secondsToDestroy);
        Destroy(gameObject);
    }

}