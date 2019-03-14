using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Collision_Detection : MonoBehaviour
{

    //public Text gameoverText;
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
            //gameoverText.text = "YOU CRASHED!!! GAME OVER!!!";
            // this.enabled = false;
            // StartCoroutine(GameOver());
            transform.position = new Vector3(-241, 22.45f, 440);
        
        }
    }


    // IEnumerator GameOver()
    // {
    //     yield return new WaitForSeconds(3);
    //     SceneManager.LoadScene("forest_level");
    // }
}
