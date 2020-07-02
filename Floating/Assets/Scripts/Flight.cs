using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;
    public float rotationSpeed;
    public Vector3 startVelocity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = startVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if (verticalInput != 0)
        {
            verticalInput = verticalInput * speed;
            transform.Rotate(verticalInput, 0, 0, Space.Self);
            //rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + verticalInput, rb.velocity.z);
        }

        if (horizontalInput != 0)
        {
            horizontalInput = horizontalInput * rotationSpeed;

            transform.Rotate(0, horizontalInput, 0, Space.Self);
        }
    }
}
