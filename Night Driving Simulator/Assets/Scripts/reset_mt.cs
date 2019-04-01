using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset_mt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("mountains_level");
        }
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name.ToString());
        //gameoverText.text = other.gameObject.name.ToString();
        if (other.gameObject.name == "reset")
        {
            Debug.Log(other.gameObject.name.ToString());
            // this.enabled = false;
            //StartCoroutine(GameOver());
            SceneManager.LoadScene("mountains_level");
        
        }
    }
}
