using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightNaturel : MonoBehaviour
{
    Rigidbody rb;

    public float speed;
    public float rotSpeed;
    public float minSpeed;
    public float maxSpeed;
    public float gravityAcc;
    public float engineAcc;
    public float failure;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * speed;
        
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (speed < maxSpeed)
                speed += engineAcc;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (speed > minSpeed)
                speed -= engineAcc;
        }
        
        if (Vector3.Dot(transform.forward, Vector3.up) > failure)
        {
            //speed down
            if (speed > minSpeed)
                speed -= gravityAcc;
        }
        else if (Vector3.Dot(transform.forward, Vector3.up) < -failure)
        {
            //speed up
            if (speed < maxSpeed)
                speed += gravityAcc;
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * rotSpeed);
            //if (speed > minSpeed)
               // speed -= acc;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * rotSpeed);
            //if (speed < maxSpeed)
               // speed += acc;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * rotSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.down * rotSpeed);
        }
    }

    public void ResetSpeed()
    {
        speed = 0;
    }
}
