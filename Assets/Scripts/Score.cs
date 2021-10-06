using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public float scoreValue = 0f;
    public Text score;
    public float pointIncreasedPerSecond;
    public float hiScoreCount;
    public float displayScore;
    public static Score instance;
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
        score = GetComponent<Text> ();
        
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
