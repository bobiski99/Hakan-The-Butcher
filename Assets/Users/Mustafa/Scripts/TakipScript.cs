using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakipScript : MonoBehaviour
{
    public Transform target;
    Vector3 mainRot;

    void Start ()
    {
        mainRot = transform.rotation.eulerAngles;
    }

    void Update()
    {
        transform.LookAt(target);
        transform.Rotate(mainRot);


    }
}
