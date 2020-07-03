using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLoc : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        player.position = transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}   
