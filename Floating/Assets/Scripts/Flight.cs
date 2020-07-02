using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float minSpeed;
    public float maxSpeed;
    public float acc;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * speed;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (speed < maxSpeed)
                speed += acc;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (speed > minSpeed)
                speed -= acc;
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
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * rotSpeed);
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
}
