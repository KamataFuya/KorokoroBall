using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleField : MonoBehaviour
{
    public float power = 10;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if(r != null)
        {
            r.AddForce(new Vector3(10, 0, 0) * power);
        }
    }
}
