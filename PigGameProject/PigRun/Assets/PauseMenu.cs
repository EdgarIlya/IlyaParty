using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject continue_button;
    public GameObject exit_button;
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
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        //Восстанавливаем исходный размер кнопки "продолжить"
        rectTransfrom = continue_button.GetComponent<RectTransform>();
        rectTransfrom.sizeDelta = new Vector2(345.7f, 64.8f); // задаем размер   new Vectro2 (width, height)
        //Восстанавливаем исходный размер кнопки "выйти из игры"
        rectTransfrom = exit_button.GetComponent<RectTransform>();
        rectTransfrom.sizeDelta = new Vector2(388.76f, 72.87f); // задаем размер   new Vectro2 (width, height)



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
