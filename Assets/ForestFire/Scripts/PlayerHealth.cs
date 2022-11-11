using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class PlayerHealth : MonoBehaviour
{
    public float playerMaxHealth;                        // creates the players maximum health number
    public float playerCurrentHealth;                   // Displays players current health status 

    public Slider healthSlider;                        //reference to health slider 

    public GameObject gameOverText;                    //reference to game over scene

    public GameObject HealthValueText;                // value for health slider 

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        //gameOverText.SetActive(false);                            // when player health is at max do not show game over text 
        HealthValueText.SetActive(true);                          // Health Score will be shown on Health Slider 
    }

    // Update is called once per frame
    void Update()
    {
        HealthValueText.SetActive(true);
        healthSlider.value = playerCurrentHealth;              // keep updating current health score 
        if (playerCurrentHealth <= 0)                         //check for if health is 0 or less 
        {
            gameOverText.SetActive(true);                   // Game over message will display 
            Time.timeScale = 0;                               // stops the game play. 
          Debug.LogError("The player has reached " + playerCurrentHealth + " health.");       //debug log error message for when player reaches 0 
        }
    }
}


//create a game over text - UI Add Text 
// add this scrip to the XR Rig to act as the player. 