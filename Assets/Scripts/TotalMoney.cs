using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalMoney : MonoBehaviour
{
    public float playerMoney;

    void Update()
    {
        playerMoney = PlayerPrefs.GetFloat("Money");
    }

    public bool TryRemoveMoney(float moneyToRemove)
    {
        if(playerMoney >= moneyToRemove)
        {
            playerMoney -= moneyToRemove;
            PlayerPrefs.SetFloat("Money", playerMoney);
            return true;
            
        }
        else
        {
            return false;
        }
    }
}
