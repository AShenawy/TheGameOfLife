using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script is responsible for controlling flow between scenes using UI buttons
// It also controls showing and hiding of the pause menu
public class SceneManager : MonoBehaviour
{
    public GameObject pausePanel;

    private void Start()
    {
        if (pausePanel)
        {
            pausePanel.SetActive(false);
        }
    }

    public void PauseGame()
    {
        if (pausePanel)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        if (pausePanel)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToScene(string sceneName)
    {
        // Destroy Game Manager to reset score.
        if (GameManager.gm)
        {
            Destroy(GameManager.gm.gameObject);
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
