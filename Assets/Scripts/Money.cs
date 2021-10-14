using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text Moneys;
    public float moneyCount = 0f;

    void Update()
    {
        moneyCount = PlayerPrefs.GetFloat("Money");
        Moneys.text = "X " + moneyCount.ToString();
    }


    public void Reset()
    {
        PlayerPrefs.DeleteKey("Money");
        Moneys.text = "X 0";
    }
}
