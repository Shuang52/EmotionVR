using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trainingRoomController : MonoBehaviour {
    int counter;

	// Use this for initialization
	void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Controller (right)").GetComponent<RControlScript>().triggerClicked)
        {
            ContinueNarration();
        }
        else if (GameObject.Find("Controller (left)").GetComponent<RControlScript>().triggerClicked)
        {
            RepeatNarration(); 
        }
    }
    
    //triggers next narration
    void ContinueNarration()
    {
        if(counter == 32)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            GameObject.Find("Olivia_Subtitle").GetComponent<OliviaTextControl>().NextSubtitle(counter);
            GameObject.Find("Audio").GetComponent<AudioSomething>().NextNarration(counter);
            GameObject.Find("Audio").GetComponent<AudioSomething>().CallAudio();
            GameObject.Find("Powerpoint").GetComponent<SlideControl>().changeSlide(counter);
            counter++;
        }
    }

    //repeats section
    void RepeatNarration()
    {
        if(counter%5 == 0 && counter > 0)
        {
            counter -= 4;
            ContinueNarration();
        }
    }

}
