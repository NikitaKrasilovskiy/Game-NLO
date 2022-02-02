using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnable : MonoBehaviour
{
    [SerializeField] private GameObject objects;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objects.SetActive(!objects.activeInHierarchy);
        }
    }
}
