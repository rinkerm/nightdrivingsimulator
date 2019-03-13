﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraSpin : MonoBehaviour
{
    [SerializeField] GameObject cam;
    void OnGUI()
    {

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 +100, 100, 50), "Play")){
            SceneManager.LoadScene("forest_level");
        }
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.Rotate(0, 5*Time.deltaTime, 0);
    }
}
