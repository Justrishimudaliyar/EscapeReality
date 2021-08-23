using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControllerTitle : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("IntroScene");
        Time.timeScale = 1f;
    }

    public void quit()
    {
        Application.Quit();
    }
}
