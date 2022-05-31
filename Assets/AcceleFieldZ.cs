using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleFieldZ : MonoBehaviour
{
    public float power = 10;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.AddForce(new Vector3(0, 0, 10) * power);
        }
    }
}
