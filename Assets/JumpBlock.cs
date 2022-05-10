using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    public float power = 8;
    public Vector3 jumpAngle = new Vector3(1, 1, 0);
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if(r != null)
        {
            r.velocity = jumpAngle.normalized * power;
        }
    }
}
