using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBehavior : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);

    }

}