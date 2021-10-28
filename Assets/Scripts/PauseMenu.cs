using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public float currentTime = 1f;
    
   

    public GameObject pauseMenuUI;

    private void Start()
    {
        currentTime = 1f;
        StartCoroutine(Hardmode());
    }


    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (GameIsPaused == true && Input.GetKeyDown(KeyCode.Space))
        {
            Resume();
        }
    }

    public void Resume ()
    {
       
            pauseMenuUI.SetActive(false);
            Time.timeScale = currentTime;
            GameIsPaused = false;
            
       
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
       
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start");
    }
    IEnumerator Hardmode()
    {
        yield return new WaitForSeconds(15);
        Time.timeScale = 1.1f;
        currentTime = Time.timeScale;
        Debug.Log("nopeus1");
        yield return new WaitForSeconds(30);
        Time.timeScale = 1.2f;
        currentTime = Time.timeScale;
        Debug.Log("nopeus2");
        yield return new WaitForSeconds(35);
        Time.timeScale = 1.3f;
        currentTime = Time.timeScale;
        Debug.Log("nopeus3");
        yield return new WaitForSeconds(40);
        Time.timeScale = 1.4f;
        currentTime = Time.timeScale;
        Debug.Log("nopeus");
        yield return new WaitForSeconds(35);
        Time.timeScale = 1.5f;
        currentTime = Time.timeScale;
        yield return new WaitForSeconds(35);
        Time.timeScale = 1.6f;
        currentTime = Time.timeScale;
        yield return new WaitForSeconds(30);
        Time.timeScale = 1.7f;
        currentTime = Time.timeScale;
        yield return new WaitForSeconds(30);
        Time.timeScale = 1.8f;
        currentTime = Time.timeScale;
        yield return new WaitForSeconds(30);
        Time.timeScale = 2f;
        currentTime = Time.timeScale;


    }
}
