using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score instance;
    public float scoreValue = 0f;
    public Text score;
    public Text HighScore;
    public float pointIncreasedPerSecond;
    public float hiScoreCount = 0f;
    public float displayScore = 0f;
    public static bool alive;
    

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        hiScoreCount = PlayerPrefs.GetFloat("HighScore:");
        scoreValue = 0;
        pointIncreasedPerSecond = 1;
        score.text = "Score: " + displayScore.ToString();
        HighScore.text = "HighScore: " + hiScoreCount.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("LastScore", displayScore);

        displayScore = (int)Mathf.Ceil(scoreValue);
       

        if (alive) //score stops counting after you die
            {
            scoreValue += pointIncreasedPerSecond * Time.deltaTime;
            score.text = "Score: " + displayScore.ToString();

        }
        if (hiScoreCount < scoreValue)
        {
            PlayerPrefs.SetFloat("HighScore:", displayScore);
            
        }
    }
    public void AddPoint() 
    {
        scoreValue += 10;
        
       score.text = "Score: " + displayScore.ToString();
    }
    
}
