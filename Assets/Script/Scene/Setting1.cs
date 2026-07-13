using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting1 : MonoBehaviour
{
    public void TouchBack()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
