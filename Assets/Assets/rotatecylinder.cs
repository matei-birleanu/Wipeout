using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed of rotation as needed

    // Update is called once per frame
    void Update()
    {
        // Rotate the cylinder around its up axis (Y-axis in world space)
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

