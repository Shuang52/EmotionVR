using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControlScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //call this function to change text
    public void changeText(string s)
    {
        GetComponent<TextMesh>().text = s;
    }
}
