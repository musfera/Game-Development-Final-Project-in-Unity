using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    
    public float threshold = -15f;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(0, 2, -1);
    }
    

     /*
    float fallZone = -10f;
    public float playerSpawnPoint = null; //create an empty gameobject and assign it to this script  in the inspector   
    void Update()
    {
        if (transform.position.y < fallZone) //Assuming its a 2D game
        {
            transform.position = playerSpawnPoint.position;
        }
    }
    */
}
