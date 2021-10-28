using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timescaler : MonoBehaviour
{
    public static Timescaler instance;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
       
    }


   
}
