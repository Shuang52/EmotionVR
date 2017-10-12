using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

    string[] answer ;
    bool check_answer;
    GameObject hit_obj;
    int counter;
    int answer_counter;

    // Use this for initialization
    void Start() {
        check_answer = false;
        counter = 0;
        answer = new string[5] {"happy", "surprise", "sad", "angry", "neutral"};
        Debug.Log("starting");
    }

    // Update is called once per frame
    void Update() {

        if (check_answer)
        {
            //Debug.Log("True:" + counter);
            //Debug.Log("Left trigger pushed: " + counter);
            if (GameObject.Find("Controller (left)").GetComponent<LaserPointer>().laserHit)
            {
                Debug.Log("laser set:" + counter);
                hit_obj = GameObject.Find("Controller (left)").GetComponent<LaserPointer>().hitObject;
                GameObject.Find("Controller (left)").GetComponent<LaserPointer>().laserHit = false;
                checkAnswer();
            }
        }
        else
        {
            //Debug.Log("False:" + counter);
            //Debug.Log("Right trigger pushed: " + counter);
            if (GameObject.Find("Controller (right)").GetComponent<RControlScript>().triggerClicked)
            {
                ContinueNarraration();
                //Debug.Log("continue narraration");
            }
        }
    }

    void ContinueNarraration()
    {
        GameObject.Find("Subtitle").GetComponent<OliviaTextPark>().NextSubtitle(counter);
        GameObject.Find("Audio").GetComponent<AudioSomething>().NextNarration(counter);
        GameObject.Find("Audio").GetComponent<AudioSomething>().CallAudio();
        checkQuestion();
        //counter++;
    }

    //asks the question
    void checkQuestion()
    {
        if (counter >= 7 && counter % 2 == 1)
        {
            check_answer = true;
        }
        else
        {
            counter++;
        }
    }
    //checks if user hits the correct person
    void checkAnswer()
    {
        if (hit_obj.tag == answer[answer_counter])
        {
            //sound plays
            //go on to next one 
            answer_counter++;
            Debug.Log("right answer!");
        }
        else
        {
            answer_counter++;
            Debug.Log("wrong answer");
        }
        check_answer = false;
        counter++;
    }
    

}


