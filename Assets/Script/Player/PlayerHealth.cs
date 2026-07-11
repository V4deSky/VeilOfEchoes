using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealt = 3;
    private int currentHealt;

    public Image[] heartImages;

    private void Awake()
    {
        currentHealt = maxHealt;
        imangeHealt();
    }

    private void Update()
    {
        
    }
    public void TakeDamage(int damage){
        currentHealt -= damage;
        imangeHealt();
        if(currentHealt == 0){
            Die();
        }
    }
    private void imangeHealt(){
        for(int i = 0; i < heartImages.Length; i++){
            heartImages[i].enabled = (i < currentHealt);
        }
    }

    void Die(){
        Destroy(gameObject);
        SceneManager.LoadScene("Menu"); // ВРЕМЕННО
    }
}
