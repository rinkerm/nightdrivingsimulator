using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
    public GameObject[] target;
    public float speed;
    private int current = 0;
    private float mpradius = 1;

    void Update()
    {
        
        // if (Vector3.Distance(target[current].transform.position, transform.position) < mpradius)
        // {
        //     current ++;
        //     if (current >= target.Length);
        //     {
        //         current = 0;
        //     }
        // }
        // transform.LookAt(target[current].transform.position);
        // transform.Rotate(0,180,0);
        // transform.position = Vector3.MoveTowards(transform.position, target[current].transform.position, speed * Time.deltaTime);
        
    }
}
