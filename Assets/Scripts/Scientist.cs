using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scientist : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        int wait_time = Random.Range(0, 4);
        yield return new WaitForSeconds(wait_time);
        print("I waited for " + wait_time + "sec");
    }
}