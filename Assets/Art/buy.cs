using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buy : MonoBehaviour
{
    public float moneyCount = 0f;
    // Start is called before the first frame update
    void Start()
    {
        moneyCount = PlayerPrefs.GetFloat("Money");
    }

    // Update is called once per frame
    public void Item1()
    {
        
    }
}
