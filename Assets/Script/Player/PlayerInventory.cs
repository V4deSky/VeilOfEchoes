using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Header("Ключ")]
    public bool hasKey = false;

    public void takeKey()
    {
        hasKey = true;
        Debug.Log("Ключ подобран");
    }
}

