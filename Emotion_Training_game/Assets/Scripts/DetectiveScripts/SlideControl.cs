using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideControl : MonoBehaviour {
	
	public Texture[] slides;
	public Renderer rend;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //changes to next slide
    public void changeSlide(int counter)
    {
        if(counter-5 < slides.Length && counter >= 6)
        {
            rend.material.mainTexture = slides[counter-5];
        }
    }
}
