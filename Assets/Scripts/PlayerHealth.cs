using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private List<Sprite> deadSprite;
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer childspriteRenderer;
    public static PlayerHealth instance;
    public GameObject childsprite;
    public float maxHealth = 100;
    public float currentHealth;
    public float decreasePerMinute;
    public HealthBar healthbar;
    public AudioSource deathSound;
    public AudioSource pickupSound;
    public static bool dead;
    public int selected;
    public ParticleSystem particles;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        particles.Stop();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        childspriteRenderer = childsprite.GetComponent<SpriteRenderer>();
        dead = false;
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
        if (currentHealth <= 0 && dead == false)
        {
            // Destroy(gameObject);
            
            StartCoroutine("Death");
            dead = true;
            
            
            
            //SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

        }
        healthbar.SetHealth(currentHealth);
    }
    
    public void PickupSound()
    {
        pickupSound.Play();
        particles.Emit(20);
    }

    IEnumerator Death()
    {
        Time.timeScale = 1;
        GetComponent<Animator>().enabled = false;
        //spriteRenderer.enabled = true;
        //childspriteRenderer.enabled = false;
        selected = Random.Range(0, deadSprite.Count);
        spriteRenderer.sprite = deadSprite[selected]; 
        deathSound.Play();
        Player player = GetComponent<Player>();
        player.CanMove = false;
        Score.alive = false;
        Score.instance.AddMoney();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
