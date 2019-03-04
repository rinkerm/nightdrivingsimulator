using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //=========================================================
    // Declarations
    //=========================================================

    [SerializeField] Rigidbody rb;
    public float forwardForce = 1f;
    public float slideForce = 100f;
    public float rotationForce = 0.8f;
    public Vector3 velocity;
    public double speed;
    public int dir;
    public int xrotation;
    [SerializeField] Camera _camera;
    [SerializeField] GameObject lrotator;
    [SerializeField] GameObject rrotator;
    [SerializeField] GameObject wlf;
    [SerializeField] GameObject wlb;
    [SerializeField] GameObject wrf;
    [SerializeField] GameObject wrb;


    //=========================================================
    // Start()
    //=========================================================
    void Start()
    {
        xrotation = 0;
        dir = 0;
        speed = 0;
        velocity = rb.velocity;
    }

    //=========================================================
    // Update()
    //=========================================================
    void Update()
    {
        Debug.Log(speed.ToString());

        if(speed < 1 && speed >-1)
        {
            dir = 0;
        }
        else if(dir == 1)
        {
            wlf.transform.Rotate(0, -5, 0);
            wrf.transform.Rotate(0, -5, 0);
            wlb.transform.Rotate(0, -5, 0);
            wrb.transform.Rotate(0, -5, 0);

        }
        else if(dir == -1)
        {
            wlf.transform.Rotate(0, 5, 0);
            wrf.transform.Rotate(0, 5, 0);
            wlb.transform.Rotate(0, 5, 0);
            wrb.transform.Rotate(0, 5, 0);
        }

        // downward force
        rb.AddRelativeForce(Vector3.down * 2);

        // help maintain cruise speed
        if (speed >= 25 && speed < 40)
        {
            rb.velocity += transform.forward * forwardForce/3 * Time.deltaTime; 
            dir = 1;
        }
        else if (speed >= 40 && speed < 50)
        {
            rb.velocity += transform.forward * forwardForce/2 * Time.deltaTime; 
            dir = 1;
        }
        else if (speed >= 50 && speed < 65)
        {
            rb.velocity += transform.forward * forwardForce/3 * Time.deltaTime; 
            dir = 1;
        }

        // different speeds for better handeling
        if (Input.GetKey(KeyCode.W))
        {
            if (speed < 10) 
            { 
                rb.velocity += transform.forward * forwardForce * Time.deltaTime;
                dir = 1;
            }
            else if (speed >= 10 && speed < 30)
            {
                rb.velocity += transform.forward * forwardForce/2 * Time.deltaTime; 
                dir = 1;
            }
            else if (speed >= 30 && speed < 35)
            {
                rb.velocity += transform.forward * forwardForce/4 * Time.deltaTime; 
                dir = 1;
            }
            else if (speed >= 35 && speed < 50)
            {
                rb.velocity += transform.forward * forwardForce/5 * Time.deltaTime; 
                dir = 1;
            }
            else if (speed >= 50 && speed < 55)
            {
                rb.velocity += transform.forward * forwardForce/3 * Time.deltaTime; 
                dir = 1;
            }
            else if (speed >= 55 && speed < 65) //superspeed sound effect?
            {
                rb.velocity += transform.forward * forwardForce/2 * Time.deltaTime; 
                dir = 1;
            }
      
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (speed > -20) { rb.velocity += -(transform.forward * forwardForce/4 * Time.deltaTime); }
            dir = -1;
        }



        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationForce, 0);

            if(xrotation < 15)
            {
                lrotator.transform.Rotate(1, 0, 0);
                rrotator.transform.Rotate(1, 0, 0);
                xrotation += 1;
            }


        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationForce, 0);

            if (xrotation > -15)
            {
                lrotator.transform.Rotate(-1, 0, 0);
                rrotator.transform.Rotate(-1, 0, 0);
                xrotation -= 1;
            }

        }
        else
        {
            if (xrotation != 0)
            {
                if(xrotation < 0)
                {
                    lrotator.transform.Rotate(1, 0, 0);
                    rrotator.transform.Rotate(1, 0, 0);
                    xrotation += 1;
                }
                else
                {
                    lrotator.transform.Rotate(-1, 0, 0);
                    rrotator.transform.Rotate(-1, 0, 0);
                    xrotation -= 1;
                }
            }
        }

        velocity = rb.velocity;
        speed = System.Math.Sqrt((velocity.x * velocity.x) + (velocity.z*velocity.z));
        speed = speed * dir;
    }


}
