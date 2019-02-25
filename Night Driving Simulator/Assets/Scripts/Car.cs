﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float forwardForce = 1f;
    public float slideForce = 100f;
    public float rotationForce = 0.8f;
    public Vector3 velocity;
    public double speed;
    public int dir;
    public int xrotation;

    [SerializeField] Camera _camera;
    [SerializeField] GameObject wlf;
    [SerializeField] GameObject wlb;
    [SerializeField] GameObject wrf;
    [SerializeField] GameObject wrb;
    // Start is called before the first frame update
    void Start()
    {
        xrotation = 0;
        dir = 0;
        speed = 0;
        velocity = rb.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if(speed < 1)
        {
            dir = 0;
        }
        if(dir == 1)
        {
            wlf.transform.Rotate(0, 5, 0);
            wrf.transform.Rotate(0, -5, 0);
            wlb.transform.Rotate(0, 5, 0);
            wrb.transform.Rotate(0, -5, 0);

        }
        else if(dir == 2)
        {
            wlf.transform.Rotate(0, -5, 0);
            wrf.transform.Rotate(0, 5, 0);
            wlb.transform.Rotate(0, -5, 0);
            wrb.transform.Rotate(0, 5, 0);

        }

        if (Input.GetKey(KeyCode.W))
        {
            if(speed<100)
                rb.velocity += transform.forward * forwardForce;
            dir = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if(speed < 100)
                rb.velocity += -(transform.forward * forwardForce);
            dir = 2;
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationForce, 0);
            /*
            if(xrotation < 20)
            {
                wlf.transform.Rotate(1, 0, 0);
                wrf.transform.Rotate(1, 0, 0);
                xrotation += 1;
            }
            */

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationForce, 0);
            /*
            if (xrotation > -20)
            {
                wlf.transform.Rotate(-1, 0, 0);
                wrf.transform.Rotate(-1, 0, 0);
                xrotation -= 1;
            }
            */
        }
        /*
        else
        {
            if (xrotation != 0)
            {
                if(xrotation < 0)
                {
                    wlf.transform.Rotate(1, 0, 0);
                    wrf.transform.Rotate(1, 0, 0);
                    xrotation += 1;
                }
                else
                {
                    wlf.transform.Rotate(-1, 0, 0);
                    wrf.transform.Rotate(-1, 0, 0);
                    xrotation -= 1;
                }
            }
        }
        */
        velocity = rb.velocity;
        speed = System.Math.Sqrt((velocity.x * velocity.x) + (velocity.z*velocity.z));
    }


}
