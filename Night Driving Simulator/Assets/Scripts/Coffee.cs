using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
    private Color startcolor = Color.white;
    public Player_Status p_status;

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
        DrinkCoffee();
    }

    void DrinkCoffee()
    {
        //playCoffeeDrinkSound
        p_status.LowerFatigue();
    }
}
