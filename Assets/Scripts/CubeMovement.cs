using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float ForceValue;

    private Rigidbody rb;

    void Start()
    {
        Physics.gravity = new Vector3(0, -20, 0);

        rb = GetComponent<Rigidbody>();

        SwipeDetection.SwipeEvent;
    }


    void Update()
    {

    }
}
