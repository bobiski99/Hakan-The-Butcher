using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{

    public GameObject ammoPro;
    public Transform gunPro;
    public float timeRate = 9f;


    private float timeToFire;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey("space") && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / timeRate;
            Fire();
        }
        
    }

    void Fire()
    {
        Rigidbody rb = Instantiate(ammoPro, gunPro.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(gunPro.forward * 500f, ForceMode.Impulse);
        Destroy(rb.gameObject, 2f);
    }

   

}
