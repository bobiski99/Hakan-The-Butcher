using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowM : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.15F;
    private Vector3 offset;

    void Start()
    {
        offset = transform.localPosition;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

}
}
