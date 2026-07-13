using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScriptScene : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    public void TouchReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void TouchMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
