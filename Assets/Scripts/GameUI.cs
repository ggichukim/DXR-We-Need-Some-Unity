using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    
    public GameObject pauseGameUI;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseGameUI.SetActive(false);
    }

    public void GameOver()
    {
        pauseGameUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseGameUI.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("spaceScene");
    }

    public void Exit() {
        Application.Quit();
    }
    
}
