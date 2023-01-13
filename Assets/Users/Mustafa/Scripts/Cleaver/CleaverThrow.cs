using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaverThrow : MonoBehaviour
{
    public GameObject Cleaver;
    private Rigidbody rb;
    private Vector3 CleaverPosition;
    private Quaternion CleaverRotation;
    public GameObject Player;

    void Start()
    {
        CleaverPosition = Cleaver.transform.localPosition;
        CleaverRotation = Cleaver.transform.localRotation;


        rb = Cleaver.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        if ( Input.GetMouseButtonDown(1))
        {
            Throw();
        }

        if (Input.GetKeyDown("r"))
        {
            rb.isKinematic = true;
            Cleaver.transform.SetParent(Player.transform);
            Cleaver.transform.localPosition = CleaverPosition;
            Cleaver.transform.localRotation = CleaverRotation;
        }
    }

    void Throw()
    {
        Cleaver.transform.SetParent(null);
        rb.isKinematic = false;
        rb.AddForce(transform.forward * 100f, ForceMode.Impulse);
    }

    
}
