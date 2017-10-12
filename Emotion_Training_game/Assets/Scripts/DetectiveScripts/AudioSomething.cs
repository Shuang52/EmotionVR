using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSomething : MonoBehaviour {
    public AudioClip[] narration;


	// Use this for initialization
	void Start () {
		
	}
    
    //fetches audio file
    public void NextNarration(int counter)
    {
        if (counter < narration.Length)
        {
            GetComponent<AudioSource>().clip = narration[counter];
            //counter++;
        }
    }

    //plays audio
    public void CallAudio()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
