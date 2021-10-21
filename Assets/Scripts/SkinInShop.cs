using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkinInShop : MonoBehaviour
{
    public SSkinInfo skinInfo;

    public Text buttonText;
    public Text error;
    public Text Equip;
    public Image skinImage;
    private bool textShowing;

    public bool isSkinUnlocked;


    private void Start()
    {
        textShowing = false;
    }

    private void Awake()
    {
        skinImage.sprite = skinInfo.skinSprite;
        IsSkinUnlocked();
    }

    private void IsSkinUnlocked()
    {
        if (PlayerPrefs.GetInt(skinInfo.skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = "Equip";
        }
    }

    public void OnButtonPress()
    {
        if (isSkinUnlocked)
        {
            //käytä
            FindObjectOfType<SkinManager>().EquipSkin(skinInfo);
            StartCoroutine (Equipped());
        }
        else
        {
            //osta
          if (FindObjectOfType<TotalMoney>().TryRemoveMoney(skinInfo.skinPrice))
            {
              
                PlayerPrefs.SetInt(skinInfo.skinID.ToString(), 1);
                IsSkinUnlocked();
            }
          else
          
            if(textShowing == false)
            {
                StartCoroutine (NoMoney());
            }
        }
    }

    IEnumerator NoMoney()
    {
        textShowing = true;
        error.text = "You don't have enough radiation";
        yield return new WaitForSeconds(2);
        error.text = "";
        textShowing = false;
    }
    IEnumerator Equipped()
    {
        textShowing = true;
        Equip.text = "Skin Equipped";
        yield return new WaitForSeconds(2);
        error.text = "";
        textShowing = false;
    }
}
