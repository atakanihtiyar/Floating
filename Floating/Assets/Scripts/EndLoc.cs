using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLoc : MonoBehaviour
{
    public Vector3 offset;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = transform.position + offset;
            other.gameObject.GetComponent<Flight>().ResetSpeed();
            Debug.Log("Finish");
        }
    }
}
