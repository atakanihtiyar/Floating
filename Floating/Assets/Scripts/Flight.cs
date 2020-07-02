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
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotSpeed1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotSpeed1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * rotSpeed1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * rotSpeed1 * Time.deltaTime);
        }
    }
}
