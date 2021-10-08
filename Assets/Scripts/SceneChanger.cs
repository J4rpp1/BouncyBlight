using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
   
  
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Game");
        }
    }
}