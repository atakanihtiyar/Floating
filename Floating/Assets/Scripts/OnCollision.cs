using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class OnCollision : MonoBehaviour
{
    public int score = 0;

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PointCircle"))
            score++;
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {

    }
}
