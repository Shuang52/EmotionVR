using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OliviaTextControl : MonoBehaviour {

    public TextAsset[] text;

    string[] subtitles;

	// Use this for initialization
	void Start () {
        TextAsset document;
        //parses documents into string array
        document = text[0];
        subtitles = document.text.Split('\n');
        Debug.Log(subtitles.Length);
	}

    //displays line of dialogue 
    public void NextSubtitle(int counter) {
        if (counter < subtitles.Length){
            GetComponent<TextMesh>().text = subtitles[counter];
            Debug.Log(subtitles[counter]);
            counter++;
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
