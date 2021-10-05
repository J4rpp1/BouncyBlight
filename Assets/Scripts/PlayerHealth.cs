using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public float maxHealth = 100;
    public float currentHealth;
    public float decreasePerMinute;
    public HealthBar healthbar;
   
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        
        
    }

    // Update is called once per frame
    
    void Update()
    {
        


        currentHealth -= Time.deltaTime * decreasePerMinute / 60f;
        if (currentHealth >= 100)
        {

            currentHealth = 100;
        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);

            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

        }
        healthbar.SetHealth(currentHealth);
    }
}
