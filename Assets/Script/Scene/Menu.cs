using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void TouchPlay()
    {
        SceneManager.LoadSceneAsync("VeiloFEChoesLevelOne");
    }
    public void TouchSettings()
    {
        SceneManager.LoadSceneAsync("Settings");
    }
    public void TouchExit()
    {
        Application.Quit();
    }
}
