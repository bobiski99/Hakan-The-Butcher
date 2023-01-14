using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaver : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject getbackObject;
    private CleaverThrow cleaverThrow;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cleaverThrow = FindObjectOfType<CleaverThrow>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Ammo"))
        {
            return;
        }
        else if (other.CompareTag("Player"))
        {
            getbackObject.SetActive(false);
            cleaverThrow.GetBack();
        }
        else
        {
            getbackObject.SetActive(true);
            rb.isKinematic = true;
        }
    }
}
