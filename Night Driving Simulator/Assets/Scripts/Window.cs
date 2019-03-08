using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public Player_Status p_status;
    private Color startcolor = Color.white;

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.blue);

    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.SetColor("_Color", startcolor);
    }
    void OnMouseDown()
    {
        MoveWindow();
    }

    void MoveWindow()
    {
        //translatewindow
        p_status.LowerFatigue();
    }
}
