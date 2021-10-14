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
        
        Score.alive = true;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        
        
    }

    // Update is called once per frame
    
    void Update()
    {
        

        Player player = GetComponent<Player>();
        
        if (player.CanMove)

        currentHealth -= Time.deltaTime * decreasePerMinute / 60f;
       
        
        if (currentHealth >= 100)
        {

            currentHealth = 100;
        }
        if (currentHealth <= 0)
        {
            // Destroy(gameObject);
            StartCoroutine("Death");
            //SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

        }
        healthbar.SetHealth(currentHealth);
    }

    IEnumerator Death()
    {
        Player player = GetComponent<Player>();
        player.CanMove = false;
        Score.alive = false;
        Score.instance.AddMoney();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
