using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControllerTitle1 : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}
