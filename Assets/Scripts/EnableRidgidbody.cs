using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRidgidbody : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.isKinematic = false;
            rb.useGravity = true;
        }
    }
}
