using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tutorial : MonoBehaviour
{
    private int tutstatus;
     private GUIStyle guiStyle = new GUIStyle();
    void OnGUI()
    {
        guiStyle.fontSize = 20;
        guiStyle.normal.textColor = Color.white;
        guiStyle.alignment = TextAnchor.UpperCenter;
        switch (tutstatus){
            case 0:
            GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 -60, 400, 120),"");
            GUI.Label(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 60, 400, 120), "Welcome to Night Driving Simulator! \nPress W and S to accelerate and brake\nA and D to turn\n\nLeft Click to Continue", guiStyle);
            break;
            case 1:
                GUI.Box(new Rect(Screen.width / 2 - 400, Screen.height / 2 - 70, 800, 140), "");
                GUI.Label(new Rect(Screen.width / 2 - 400, Screen.height / 2 - 70, 800, 140), "The object of the game is to stay awake while driving and make it to your destination.\nAs you drive you will get tired.\n This is represented by the fatigue meter in the lower left corner.\n If this meter becomes full, you lose.\n\nLeft Click to Continue", guiStyle);
                break;
            case 2:
            GUI.Box(new Rect(Screen.width / 2 - 400, Screen.height / 2 - 70, 800, 140), "");
            GUI.Label(new Rect(Screen.width / 2 - 400, Screen.height / 2 - 70, 800, 140), "Inside your car, you can look around using the mouse.\nFind and click on the green buttons for your window, radio, and coffee.\nEach of these buttons highlights blue indicating you can click on it.\nClicking on them will keep you awake and stop you from blinking.\n\nLeft Click to Continue", guiStyle);
            break;
            case 3:
                GUI.Box(new Rect(Screen.width / 2 - 400, Screen.height / 2 - 60, 800, 120), "");
                GUI.Label(new Rect(Screen.width / 2 - 400, Screen.height / 2 - 60, 800, 120), "These are your cooldown meters.\nClicking on either the window, radio, or coffee will fill its respective meter.\nYou will not be able to use the effects of each item until its meter has depleted.\n\nLeft Click to Continue.", guiStyle);
                break;
            case 4:
            GUI.Box(new Rect(Screen.width / 2 - 320, Screen.height / 2 - 50, 640, 100), "");
            GUI.Label(new Rect(Screen.width / 2 - 320, Screen.height / 2 - 50, 640, 100), "Watch out for other cars and animals and follow the road.\nIf you get stuck press 'P' to reset the current level.\n\nLeft Click to Continue", guiStyle);
            break;
            case 5:
                GUI.Box(new Rect(Screen.width / 2 - 320, Screen.height / 2 - 50, 640, 100), "");
                GUI.Label(new Rect(Screen.width / 2 - 320, Screen.height / 2 - 50, 640, 100), "You can now drive around an experiment with the controls of the game.\nWhen you are ready click the button to return to the main menu.\n\nClick to Continue", guiStyle);
                break;
            default:
                if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 200, 200, 40), "Main Menu"))
                {
                    SceneManager.LoadScene("start");
                }
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tutstatus = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tutstatus += 1;
        }
    }

    public int getStatus()
    {
        return (tutstatus);
    }
}
