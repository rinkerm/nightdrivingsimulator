using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Status : MonoBehaviour
{
    [SerializeField] GameObject top_eyelid;
    [SerializeField] GameObject bottom_eyelid;
    public float b_speed = .25f;
    private int b_direction = -1;
    public float b_time = 0.1f;
    private int b_timer = 0;
    private int b_threshhold = 600;
    private bool blinking = false;
    private float fatigue = 0;
    private int timer = 0;
    private int fatigue_threshold = 150;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > fatigue_threshold)
        {
            fatigue++;
            Debug.Log(fatigue);
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

    IEnumerator blink()
    {
        blinking = true;
        while(top_eyelid.transform.localPosition.y > .25)
        {
            top_eyelid.transform.Translate(new Vector3 (0, -b_speed, 0), Space.Self);
            bottom_eyelid.transform.Translate(new Vector3(0, b_speed, 0), Space.Self);
            yield return 0;
        }
        yield return new WaitForSeconds(b_time);
        while (top_eyelid.transform.localPosition.y < .5)
        {
            top_eyelid.transform.Translate(new Vector3(0, b_speed, 0), Space.Self);
            bottom_eyelid.transform.Translate(new Vector3(0, -b_speed, 0), Space.Self);
            yield return 0;
        }
        blinking = false;
    }
 
    
}
