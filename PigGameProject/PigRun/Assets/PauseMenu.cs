using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject continue_button;
    public GameObject pauseMenuUI;
    private RectTransform rectTransfrom;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        rectTransfrom = continue_button.GetComponent<RectTransform>();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        //button1.texture.Resize(640, 480);
        rectTransfrom.sizeDelta = new Vector2(345.7f, 64.8f); // задаем размер   new Vectro2 (width, height)
        //continue_button.transform.
           //gameObject.transform.
        //localScale = new Vector2(1f, 1f);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
