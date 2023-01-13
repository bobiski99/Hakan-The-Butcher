using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaver : MonoBehaviour
{
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.CompareTag("Ammo"))
        {
            return;
        }
        else
        {
            rb.isKinematic = true;
        }
    }
}
