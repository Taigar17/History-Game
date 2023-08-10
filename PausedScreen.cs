using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//This script pauses the game when pressing 'Escape' key
public class PausedScreen : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    //public KeyCode pauseKey;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1; //Set the timescale to 1 for restart option to work
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
            /*if (isPaused)
                Time.timeScale = 0; //Sets the timescale to 0 - Everything stops
            else
                Time.timeScale = 1; //Sets the timescale to 1 - Everything continues 
            */
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; //Stops in game clock
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; //Resumes time in game
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        //Loads Main Menu Scene
    }

    public void QuitGame()
    {
        Application.Quit();
        //Quits game when its built
    }
}
