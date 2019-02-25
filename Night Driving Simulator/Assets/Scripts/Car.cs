using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float forwardForce = 1f;
    public float slideForce = 100f;
    public float rotationForce = 1f;

    [SerializeField] Camera _camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity += transform.forward * forwardForce;
        }

        if (Input.GetKey(KeyCode.S))
            {
            rb.velocity += -(transform.forward * forwardForce);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationForce, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationForce, 0);
        }
    }
}
