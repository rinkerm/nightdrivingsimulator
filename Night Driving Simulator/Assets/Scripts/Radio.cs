using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    private Color startcolor = Color.white;
    public Player_Status p_status;

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.SetColor("_Color",Color.blue);
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.SetColor("_Color",startcolor);
    }

    void OnMouseDown()
    {
        ChangeRadio();
    }

    void ChangeRadio()
    {
        //music stuff
        p_status.LowerFatigue();
    }
}
