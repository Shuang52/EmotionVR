using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OliviaTextPark : MonoBehaviour {

    public TextAsset text;
    string[] subtitles;

	// Use this for initialization
	void Start () {
        subtitles = text.text.Split('\n');

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //displays line of dialogue 
    public void NextSubtitle(int counter)
    {
        if (counter < subtitles.Length)
        {
            GetComponent<TextMesh>().text = subtitles[counter];
            Debug.Log(subtitles[counter]);
            //counter++;
        }
    }
}
