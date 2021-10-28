using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] Transform Position1;
    [SerializeField] Transform Position2;
    [SerializeField] private List<Sprite> Sprites;
    //[SerializeField] float ObjectSpeed = 10f;
    private Vector3 velocity = Vector3.zero;
    public Transform firePoint;
    public GameObject firePrefab;
    public SpriteRenderer spriteRenderer;
    public int selected;
    public AudioSource warning;
    public AudioSource fire;
    public Animator animator;



    void Start()
    {
        StartCoroutine(Waiter());
        transform.position = Position1.position;
       // animator.SetBool("IsVisible", false);
       // animator.SetBool("GoAway", false);

    }


    private void Update()
    {

    }
   
    IEnumerator Waiter()
    {
        while (true)
        {
            
            int wait_time = Random.Range(4, 15);
            yield return new WaitForSeconds(wait_time);
            /*spriteRenderer = gameObject.GetComponent<SpriteRenderer>(); 
            selected = Random.Range(0, Sprites.Count);                  //valitsee random spriten
            spriteRenderer.sprite = Sprites[selected];    */              //vaihtaa spriten random hahmoksi
            transform.position = Position2.position;
            warning.Play();
            animator.SetBool("IsVisible", true);
            yield return new WaitForSeconds(1.5f);
            Instantiate(firePrefab, firePoint.position, firePoint.rotation);
            fire.Play();
            yield return new WaitForSeconds(2);
            animator.SetBool("IsVisible", false);
            animator.SetBool("GoAway", true);
            yield return new WaitForSeconds(1.5f);
            transform.position = Position1.position;
            animator.SetBool("GoAway", false);
        }
    }

}



   