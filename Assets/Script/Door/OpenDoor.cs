using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    private Collider2D myCollider;
    [SerializeField]private string scene;
    private void Awake()
    {
        myCollider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInv = other.gameObject.GetComponent<PlayerInventory>();
            if(playerInv != null && playerInv.hasKey == true)
            {
                myCollider.isTrigger = true;
                SceneManager.LoadScene(scene);
            }
            else
            {
                Debug.Log("playerInv == null");
            }
        }
    }
}
