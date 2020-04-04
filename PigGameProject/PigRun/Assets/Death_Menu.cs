using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death_Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject deathMenuUI;
    void Update()
    {
        if ((GameObject.Find("Pig") == null))
        {
                Pause();
        }
    }

    public void Restart()
    {
        
        SceneManager.LoadScene("SampleScene");
        //SceneManager.GetActiveScene();

        /*
        //Time.timeScale = 1f;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.UnloadScene("SampleScene");
        deathMenuUI.SetActive(false);
        Time.timeScale = 1f;
         GameIsPaused = false;
         deathMenuUI.SetActive(false);
         Time.timeScale = 1f;
         GameIsPaused = false; 
         */
    }

    void Pause() 
    {
        deathMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
