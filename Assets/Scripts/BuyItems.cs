using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItems : MonoBehaviour
{
    public float moneyCount = 0f;
    public float canBuy1 = 0f;
    public Text buyText1;
    public Text buyText2;
    public Text radiation;
    // Start is called before the first frame update
    void Start()
    {
       
        buyText1.text = "Buy";
        buyText2.text = "Buy";

    }

    private void Update()
    {
        moneyCount = PlayerPrefs.GetFloat("Money");
        canBuy1 = PlayerPrefs.GetFloat("Item1Bought");

        if (canBuy1 > 0)
        {
            buyText1.text = "Bought";
        }
    }
    // Update is called once per frame
    public void BuyItem1()
    {
        if (moneyCount > 10 && canBuy1 < 1 && canBuy1 > -1)
        {
            moneyCount -= 10f;
            PlayerPrefs.SetFloat("Money", moneyCount);
            Debug.Log("onnistui");
            PlayerPrefs.SetFloat("Item1Bought", 1);
        }
        if (moneyCount < 10 && canBuy1 < 1)
        {
            StartCoroutine(noMoney());
          

        }
    }
    IEnumerator noMoney()
    {
        radiation.text = "You don't have enough radiation";
        yield return new WaitForSeconds(1);
        radiation.text = "";
    }

    public void SelectItem()
    {
        PlayerPrefs.SetFloat("itemSelected", 1);
        
    }
}
