using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerCollision : MonoBehaviour {
    float speed = 10f;
	// Use this for initialization
	void OnCollisionStay (Collision other) {
		
        if (other.gameObject.tag == "Player")
        {
            gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
            doSomething();
        }
	}
	
    void onTriggerSay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * speed);
            doSomething();
        }
    }
	// Update is called once per frame
	void doSomething () {
        Debug.Log("like, comm");
		
	}
}
