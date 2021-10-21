using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetMenu : MonoBehaviour
{

    public GameObject deleteMenuUI;
 

    // Update is called once per frame
   public void OpenMenu()
    {
        deleteMenuUI.SetActive(true);
    }

    public void CloseMenu()
    {
        deleteMenuUI.SetActive(false);
    }
}
