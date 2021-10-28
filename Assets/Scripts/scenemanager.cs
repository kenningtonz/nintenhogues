using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
   
    public void play()
    {
        SceneManager.LoadScene("Play");

    }
    public void home()
    {
        SceneManager.LoadScene("Home");
    }
    public void pick()
    {
        SceneManager.LoadScene("Pick");
    }
    public void end()
    {
        SceneManager.LoadScene("End");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
