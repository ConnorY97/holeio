using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other != null)
        {
            Debug.Log(other.tag);
            if (other.gameObject.tag == "Object")
            {
                Rigidbody otherRB = other.gameObject.GetComponent<Rigidbody>();
                if (otherRB != null)
                    otherRB.useGravity = true;
                else
                    Debug.Log("Object is missing rb");
            }
        }
        */
    }
}
