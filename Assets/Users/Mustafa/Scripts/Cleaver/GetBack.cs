using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBack : MonoBehaviour
{
    private CleaverThrow cleaverThrow;

    void Start()
    {
        cleaverThrow = FindObjectOfType<CleaverThrow>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cleaverThrow.Player)
        {
            cleaverThrow.GetBack();
        }
    }
}
