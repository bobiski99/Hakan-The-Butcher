using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaver : MonoBehaviour
{
    private Rigidbody rb;
    public SphereCollider colliderC;
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
        else if (other.CompareTag("Player"))
        {
            colliderC.radius = 0.1F;
        }
        else
        {
            rb.isKinematic = true;
            colliderC.radius = 2.5F;
        }
    }
}
