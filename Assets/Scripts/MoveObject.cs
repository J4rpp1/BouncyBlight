using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] Transform Position1;
    [SerializeField] Transform Position2;
    [SerializeField] float ObjectSpeed = 10f;
    private Vector3 velocity = Vector3.zero;
    public Transform firePoint;
    public GameObject firePrefab;



    void Start()
    {
        StartCoroutine(waiter());
        transform.position = Position1.position;
        
    }


    private void Update()
    {

    }
   
    IEnumerator waiter()
    {
        while (true)
        {
            int wait_time = Random.Range(4, 15);
            yield return new WaitForSeconds(wait_time);
            print("I waited for " + wait_time + "sec");
            transform.position = Position2.position;
            yield return new WaitForSeconds(1);
            Instantiate(firePrefab, firePoint.position, firePoint.rotation);
            yield return new WaitForSeconds(3);
            transform.position = Position1.position;
        }
    }

}



   