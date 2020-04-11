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

        if ((GameObject.Find("Pig") != null))
        {
            sharedvariables.DeathMenuActive = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        sharedvariables.StopFlip = false;
        
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
        sharedvariables.DeathMenuActive = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
