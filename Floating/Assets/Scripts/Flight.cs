using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;
    public float rotSpeed1;
    public Vector3 baseVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * speed;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotSpeed1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotSpeed1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * rotSpeed1);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * rotSpeed1);
        }
    }
}
