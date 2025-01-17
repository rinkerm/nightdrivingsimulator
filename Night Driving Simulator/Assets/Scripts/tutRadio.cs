﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutRadio : MonoBehaviour
{
    public Tutorial tut;
    //=========================================================
    // GUI Stuff
    //=========================================================
    public float barDisplay; //current progress
    public Vector2 pos = new Vector2(330, 500);
    public Vector2 size = new Vector2(60, 20);
    public Texture2D emptyTex;
    public Texture2D fullTex;
    private static GUIStyle fullbar;

    void OnGUI()
    {
        if (tut.getStatus() > 2)
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
            GUI.Label(new Rect(pos.x, pos.y - 20, size.x, size.y), "Radio");
            GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
            GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);

            //draw the filled-in part:
            GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
            GUI.Box(new Rect(0, 0, size.x, size.y), GUIContent.none, fullbar);
            GUI.EndGroup();
            GUI.EndGroup();
        }
    }

    //=========================================================
    // Declarations
    //=========================================================
    private Color startcolor = Color.white;
    public tutPlayer_Status p_status;
    private float radioCD = 0f;
    private int radioCDL = 30;

    private int punk = 0;
    public AudioClip[] music;
    public AudioSource MusicSource;

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
        ChangeRadio();
    }

    void Start()
    {

        MusicSource.clip = music[0];
        MusicSource.Play();
    }

    //=========================================================
    // Update
    //=========================================================
    void Update()
    {
        barDisplay = radioCD / 60f;
        radioCD -= Time.deltaTime;
        if (radioCD < 0 && punk == 1)
        {
            punk = 0;
            MusicSource.clip = music[0];
            MusicSource.Play();
        }
    }

    //=========================================================
    // ChangeRadio
    //=========================================================
    void ChangeRadio()
    {
        if (radioCD < 0)
        {
            punk = 1;
            //translatewindow
            p_status.LowerFatigue(30);
            radioCD = radioCDL;

            MusicSource.clip = music[1];
            MusicSource.Play();
        }
    }
}
