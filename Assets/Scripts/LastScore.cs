using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour
{
    public Text Yourscore;
    public float Score = 0f;


    void Start()
    {
        Score = PlayerPrefs.GetFloat("LastScore");
        Yourscore.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
