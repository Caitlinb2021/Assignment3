using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{ 
    public GameObject FireEngine;                   // object reference 
    public SpawnFireEngine spawnFireEngine;         // reference to spawn function 

    public void Awake()
    {
     spawnFireEngine = GameObject.FindGameObjectWithTag("FireEngine").GetComponent<SpawnFireEngine>();      // find fire engine game tag 
        Debug.Log("FireEnginefound");                                                                       // message that fire engine prefab has been turned on 
    }
    public void OnTriggerEnter(Collider other)
    { 
        if(other.tag == "PlayerHand")                                                                    // once player hand touches the button it will activate 
        {
            buttionmethode();                                                                           // turn on button 
        }
    }

    public void buttionmethode()
    {
        Debug.LogError("Emergency Services have been called!!!");                                      // message to show button has been pressed 
        spawnFireEngine.Spawn();                                                                       // now button is activated fire engine will spawn. 
    } 
}
