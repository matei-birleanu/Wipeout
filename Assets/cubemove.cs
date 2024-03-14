using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float moveDistance = 1.0f; // Distance to move up and down
    public float moveSpeed = 2.0f; // Speed of movement
    public bool isAsynchronous = true; // Flag to indicate asynchronous movement

    private Vector3 initialPosition;
    private float startTime;

    void Start()
    {
        initialPosition = transform.position;
        if (isAsynchronous)
        {
            // Start the asynchronous movement with a delay
            float delay = Random.Range(0.0f, 2.0f); // You can adjust the delay range
            startTime = Time.time + delay;
        }
    }

    void Update()
    {
        if (isAsynchronous && Time.time < startTime)
        {
            // Wait until the start time is reached for asynchronous cubes
            return;
        }

        // Calculate the new Y position using a sine wave
        float newXPos = initialPosition.x + Mathf.Sin((Time.time - startTime) * moveSpeed) * moveDistance;
        transform.position = new Vector3(newXPos, initialPosition.y, initialPosition.z);


    }



}