using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class crash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name.ToString());
        //gameoverText.text = other.gameObject.name.ToString();
        if (other.gameObject.name == "traffic_car")
        {
            Debug.Log(other.gameObject.name.ToString());
            // this.enabled = false;
            //StartCoroutine(GameOver());
            SceneManager.LoadScene("gameover");
        
        }
    }


    // IEnumerator GameOver()
    // {
    //     yield return new WaitForSeconds(1);
    //     SceneManager.LoadScene("forest_level");
    // }
}
