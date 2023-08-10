using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Start Game
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//All of these examples load "level 0"
    }

    //Quit Game
    public void QuitGame()
    {
        Debug.Log("Quit!"); //Prints in Unity console 
        Application.Quit();
    }
}