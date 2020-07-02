using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerCamera : MonoBehaviour
{
    public Vector3 offset;
    public GameObject followingObject;

    // Update is called once per frame
    void Update()
    {
        transform.position = followingObject.transform.position + offset;
        transform.rotation = followingObject.transform.rotation;
    }
}
