using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioSource start;
    private static GameObject instance;

    // Start is called before the first frame update
    void Start()

    {
        DontDestroyOnLoad(gameObject);
       
    }

    // Update is called once per frame
    public void Playstart()
    {
        start.Play();
        StartCoroutine(Destroy());
    }

    public void Menu()
    {
        start.Play();
        
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
