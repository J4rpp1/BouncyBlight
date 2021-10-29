using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{

    public bool InfoShown;
    public float info;


    private void Start()
    {
       info = PlayerPrefs.GetFloat("Info");

        if(info > 1)
        {
            InfoShown = true;
        }
    }

    public void StartGame()
    {
        if(InfoShown == false)
        {
            SceneManager.LoadScene("Info", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
        
    }

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


    public void QuitGame()
    {
        Application.Quit();
    }

    public void Info()
    {
        SceneManager.LoadScene("Info", LoadSceneMode.Single);
    }
}