using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text HighScore;
    public float hiScoreCount = 0f;

    void Start()
    {
        hiScoreCount = PlayerPrefs.GetFloat("HighScore:");
        HighScore.text = "HighScore: " + hiScoreCount.ToString();
    }

    
    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore:");
        HighScore.text = "HighScore: 0";
    }
}
