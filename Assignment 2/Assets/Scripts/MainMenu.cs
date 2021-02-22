using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    void Start ()
    {

    }
    public void Play()
    {
        Time.timeScale = 1f;    
        SceneManager.LoadScene("MainScene");
    }

    public void doExitGame()
    {
        Debug.Log("game terminated");
        Application.Quit();
    }

}
