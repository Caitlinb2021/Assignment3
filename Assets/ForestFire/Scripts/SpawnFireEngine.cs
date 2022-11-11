using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireEngine : MonoBehaviour
{
    public Vector3 phoneBoxPosition;                   // find Phone Box Position 
    public GameObject FireEngine;                     //makes reference to object                                        

    // Start is called before the first frame update
   public void Spawn()                               //spawn the fire engine into the scene 
    {
        Debug.LogError("Fire Engine on the way");

        FireEngine.SetActive(true);                 // the fire engines mesh will turn on 
        
        FireEngine.transform.position += new Vector3(phoneBoxPosition.x, phoneBoxPosition.y, phoneBoxPosition.z);      // fire engine will spawn to position that the phone booth is in 
    }
}
