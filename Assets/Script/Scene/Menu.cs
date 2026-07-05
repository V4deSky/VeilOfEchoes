using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void TouchPlay()
    {
        SceneManager.LoadScene("VeiloFEChoesLevelOne");
    }
    public void TouchExit()
    {
        Application.Quit();
    }
}
