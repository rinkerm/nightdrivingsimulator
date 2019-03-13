using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    //=========================================================
    // Declarations
    //=========================================================
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumVert = -20.0f;
    public float maximumVert = 45.0f;
    public float minimumHor = -60f;
    public float maximumHor = 60f;
    private float _rotationX = 0;
    private float _rotationY = 0;

    //=========================================================
    // Start
    //=========================================================
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
    }

    //=========================================================
    // Update
    //=========================================================
    void Update()
    {
		_rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
		_rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
        _rotationY += Input.GetAxis("Mouse X") * sensitivityHor;
        _rotationY = Mathf.Clamp(_rotationY, minimumHor, maximumHor);
		transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
    }
}
