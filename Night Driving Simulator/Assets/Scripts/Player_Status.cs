using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Status : MonoBehaviour
{
    //=========================================================
    // Declarations
    //=========================================================
    [SerializeField] GameObject top_eyelid;
    [SerializeField] GameObject bottom_eyelid;
    public float b_speed = .25f;
    public float b_time = 0.1f;
    private int b_timer = 0;
    private int b_threshhold = 600;
    private bool blinking = false;
    private float fatigue = 0;
    private int timer = 0;
    private int fatigue_threshold = 60;


    //=========================================================
    // GUI Stuff
    //=========================================================
    public float barDisplay; //current progress
    public Vector2 pos = new Vector2(20, 500);
    public Vector2 size = new Vector2(120, 20);
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
        GUI.Label(new Rect(pos.x, pos.y - 20, size.x, size.y), "Fatigue");
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);

        //draw the filled-in part:
        GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), GUIContent.none, fullbar);
        GUI.EndGroup();
        GUI.EndGroup();
    }

    //=========================================================
    // Start
    //=========================================================
    void Start()
    {
        fullTex = new Texture2D(1, 1);
        fullTex.SetPixel(0, 0, Color.white);
        fullTex.Apply();
    }

    //=========================================================
    // Update
    //=========================================================
    void Update()
    {
        barDisplay = fatigue*0.01f;
        //Debug.Log(fatigue);
        if (timer * Time.deltaTime > fatigue_threshold * Time.deltaTime)
        {
            fatigue++;
            timer = 0;
        }
        if (fatigue > 100)
        {
            fatigue = 100;
            //game over
        }
        timer++;
        if(!blinking)
        { 
            if(b_timer > b_threshhold)
            {
                StartCoroutine(blink());
                
                b_timer = 0;
            }
            else
            {
                b_timer++;
            }
        }
        b_time = 0.1f + (fatigue / 175);
        b_speed = System.Math.Max(.25f - (fatigue / 425),.01f);
    }

    //=========================================================
    // Blink
    //=========================================================
    IEnumerator blink()
    {
        blinking = true;
        while(top_eyelid.transform.localPosition.y > .25)
        {
            top_eyelid.transform.Translate(new Vector3 (0, -b_speed*Time.deltaTime, 0), Space.Self);
            bottom_eyelid.transform.Translate(new Vector3(0, b_speed * Time.deltaTime, 0), Space.Self);
            yield return 0;
        }
        yield return new WaitForSeconds(b_time);
        while (top_eyelid.transform.localPosition.y < .5)
        {
            top_eyelid.transform.Translate(new Vector3(0, b_speed * Time.deltaTime, 0), Space.Self);
            bottom_eyelid.transform.Translate(new Vector3(0, -b_speed * Time.deltaTime, 0), Space.Self);
            yield return 0;
        }
        blinking = false;
    }

    //=========================================================
    // LowerFatigue
    //=========================================================
    public void LowerFatigue()
    {
        fatigue = System.Math.Max(0, fatigue - 10);
    }
    
}
