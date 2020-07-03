using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerCamera : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public float offsetYMultiplier;
    public float offsetZMultiplier;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 offset = (offsetYMultiplier * target.up) - (offsetZMultiplier * target.forward);
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
