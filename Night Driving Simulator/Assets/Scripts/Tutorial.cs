using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public float x;
    private int tutstatus;
     private GUIStyle guiStyle = new GUIStyle();
    void OnGUI()
    {
        guiStyle.fontSize = 20;
        guiStyle.normal.textColor = Color.white;
        switch(tutstatus){
            case 0:
            GUI.Box(new Rect(5, 5, 400, 60),"");
            GUI.Label(new Rect(10, 10, 200, 100), "Welcome to Night Driving Simulator! \nUse the keyboard keys WASD to move.", guiStyle);
            break;
            case 1:
            GUI.Box(new Rect(5, 5, 500, 90),"");
            GUI.Label(new Rect(10, 10, 200, 100), "Inside your car, you can click on the green buttons for your window, radio, and coffee.\nEach of these buttons highlights blue indicating you can click on it.\nClicking on them will keep you awake and stop you from blinking.\nEvery time you click one, you must wait until the specefic meter is empty to click again.", guiStyle);
            break;
            case 2:
            GUI.Box(new Rect(5, 5, 200, 60),"");
            GUI.Label(new Rect(10, 10, 200, 100), "If your fatigue meter fills all the way, you lose!\nWatch out for other cars and animals and follow the road.\nIf you get stuck press 'P' to reset the current level.", guiStyle);
            break;
            default:
            break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tutstatus = 0;
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {       
        x+=Time.deltaTime;
        if(x>12){
            tutstatus = 1;
        }
        if(x>30){
            tutstatus = 2;
        }
        if(x>45){
            tutstatus = 3;
        }
    }
}
