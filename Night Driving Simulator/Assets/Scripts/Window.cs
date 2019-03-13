using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    //=========================================================
    // GUI Stuff
    //=========================================================
    public float barDisplay; //current progress
    public Vector2 pos = new Vector2(240, 500);
    public Vector2 size = new Vector2(60, 20);
    public Texture2D emptyTex;
    public Texture2D fullTex;
    private static GUIStyle fullbar;

    void OnGUI()
    {
        if (fullTex == null)
        {
            fullTex = new Texture2D(1, 1);
        }

        if (fullbar == null)
        {
            fullbar = new GUIStyle();
        }

        fullTex.SetPixel(0, 0, Color.blue);
        fullTex.Apply();

        fullbar.normal.background = fullTex;
        //draw the background:
        GUI.Label(new Rect(pos.x, pos.y - 20, size.x, size.y), "Window");
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);

        //draw the filled-in part:
        GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), GUIContent.none, fullbar);
        GUI.EndGroup();
        GUI.EndGroup();
    }

    //=========================================================
    // Declarations
    //=========================================================
    public Player_Status p_status;
    private Color startcolor = Color.white;
    private float windowCD = 0f;
    private int windowCDL = 20;

    //=========================================================
    // Mouse Stuff
    //=========================================================
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

    //=========================================================
    // Update
    //=========================================================
    void Update()
    {
        barDisplay = windowCD / 20f;
        windowCD -= Time.deltaTime;
    }

    //=========================================================
    // MoveWindow
    //=========================================================
    void MoveWindow()
    {
        if (windowCD < 0)
        {
            //translatewindow
            p_status.LowerFatigue();
            windowCD = windowCDL;
        }
    }
}
