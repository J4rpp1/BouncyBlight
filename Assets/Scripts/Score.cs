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
    public float displayScore;
    public static bool alive;
    

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        pointIncreasedPerSecond = 1;
        score.text = "Score" + displayScore.ToString();
        HighScore.text = "HighScore" + hiScoreCount.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        displayScore = Mathf.Ceil(scoreValue);
        //score.text = (int)scoreValue + "Score";

        if (alive) //score stops counting after you die
            {
            scoreValue += pointIncreasedPerSecond * Time.deltaTime;
            score.text = "Score:" + displayScore;
        }
    }
    
}
