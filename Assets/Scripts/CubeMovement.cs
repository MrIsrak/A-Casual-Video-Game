using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float ForceValue;
    //private Activator sleep;
    private Rigidbody rb;

    void Start()
    {
        Physics.gravity = new Vector3(0, -20, 0);

        rb = GetComponent<Rigidbody>();
        //sleep = GetComponent<Activator>();

        //sleep.fade();
        //SwipeDetection;
    }


    void Update()
    {
        transform.position = transform.position + new Vector3(1.50f, 0, 0);
    }
}
