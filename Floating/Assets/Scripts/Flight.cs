using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;
    public Vector3 startVelocity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = startVelocity * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
