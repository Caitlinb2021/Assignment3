using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyFire : MonoBehaviour
{
    public PlayerHealth PlayerHealthScript;
    public float DamageNumber;                     // creates a damage value 
    public GameObject FireEngine;                 // reference to fire engine 
    public GameObject YouWonText;                  // reference to you won scene 

    // Start is called before the first frame update

    public void Awake()
    {
        PlayerHealthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();             // finds the player 
        YouWonText = GameObject.FindGameObjectWithTag("YouWon"); 

    }
    void Start()
    {
       // YouWonText.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            PlayerHealthScript.playerCurrentHealth = PlayerHealthScript.playerCurrentHealth - DamageNumber;      //calculates health score once collided with an object
        Debug.Log("The players current health is " + PlayerHealthScript.playerCurrentHealth);  //debug log the current player health
    }
    public void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.gameObject.tag == "FireEngine")                    // if fire collides with the fire engine 
        {
            Debug.Log("The fire has been put out");
            Destroy(gameObject);                                        // destory fire once it collides with fire engine 
            YouWonText.SetActive(true);                      // change to you have won screen
        }
        else     
            Debug.Log("The Fire has not been put out");
        }
       
    }
     

// add rigidbody to player 
// add on trigger to enemy collider 
