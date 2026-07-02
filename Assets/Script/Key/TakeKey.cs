using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInv = other.GetComponent<PlayerInventory>();
            if(playerInv != null)
            {
                playerInv.takeKey(); Destroy(gameObject);
            }
            else
            {
                Debug.Log("Скрипт не весит PlayerInv");
            }
        }
    }
}
