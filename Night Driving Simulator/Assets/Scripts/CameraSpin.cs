using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraSpin : MonoBehaviour
{

    [SerializeField] GameObject cam;
    void OnGUI()
    {

        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 40), "Tutorial")){
            SceneManager.LoadScene("tutorial");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 40), "Story Focused Mode"))
        {
            //SceneManager.LoadScene("mountains_level");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 200, 40), "Normal Mode"))
        {
            SceneManager.LoadScene("mountains_level");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 200, 200, 40), "Credits"))
        {
            SceneManager.LoadScene("credits");
        }
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.Rotate(0, 5*Time.deltaTime, 0);
    }
}
