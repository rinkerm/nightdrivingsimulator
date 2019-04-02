using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public AudioClip narration;
    public AudioSource player;
    public GUIStyle style;
    void OnGUI()
    {
        string story = "\n\nA stretch of asphalt wound up the cliff face, black and bright as the backside of a coral snake.\n\nIt was the road home, familiar to you, and for that reason all the more treacherous.\n\nIt had been a late night at the office,\na grueling shift punctuated with small doses of a new allergy medication and stale coffee.\n\nThe way you saw it, you spend the night in your cubicle \n\n(a choice for which your lower back would pay dearly the next morning),\n\nor you could risk your life driving home\n\n\nBefore you could make an informed decision, you were behind the wheel of your car,\n\nrolling out of the city and into the wilderness.\n\n\nThe night sky has a purplish tint to it, giving your once familiar world a new, almost mystic quality.\n\nYou stare up at the stars,\nleaning forward over the steering wheel, feeling it press into your diaphragm like the probing fist of a surgeon.\n\nYour car lolls into the opposite lane of traffic, and then out of it, and suddenly your brights cast tall, bright lights along the side of the mountain.\n\n\nYou veer back into your lane, your right headlight colliding with an errant plane of rock.\nYou pull of the road, startled from your drug-induced daze, and examine your headlight.\n\n\nIt’s another fifteen or twenty minutes to your house from here, on a winding two-lane highway, equidistant from your office and the congestion of the city.";
        style.fontSize = 20;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.UpperCenter;
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), story, style);
        if (GUI.Button(new Rect((Screen.width - 300) / 2, Screen.height - 100, 300, 50), "Click to Skip"))
        {
            SceneManager.LoadScene("forest_level");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        player.clip = narration;
        player.Play();
        //StartCoroutine(waitForPlay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitForPlay()
    {
        yield return new WaitForSeconds(100);
        SceneManager.LoadScene("forest_level");
    }
}
