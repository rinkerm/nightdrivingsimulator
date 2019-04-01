using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    public GUIStyle style;
    void OnGUI()
    {
        string credits = "\n\n\nCredits:\n\nTeam Lead: Gezim Saciri\n\nDesign Lead: Kush Patel\n\nCode Lead: Matthew Rinker\n\nTeam Liason: Kush Patel\n\nComposer: James Braham\n\nStory Writer: Izzy Ostrowski";
        style.fontSize = 20;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.UpperCenter;
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), credits, style);
        if (GUI.Button(new Rect((Screen.width - 300) / 2, Screen.height - 100, 300, 50), "Return to Main Menu"))
        {
            SceneManager.LoadScene("start");
        }
    }
}
