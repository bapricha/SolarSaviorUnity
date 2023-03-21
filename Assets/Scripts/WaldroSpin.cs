using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaldroSpin : MonoBehaviour
{

    private float z;
    private float rotationSpeed;
    void Start()
    {
        transform.localRotation = Quaternion.identity;
        z = 0.0f;
        rotationSpeed = 30.0f;
    }

    void FixedUpdate()
    {
        z += Time.deltaTime * rotationSpeed;

            if (z >= 360.0f)
                z = 0.0f;
        transform.localRotation = Quaternion.Euler(0, 0, z);
    }
}
