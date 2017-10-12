using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RControlScript : MonoBehaviour {
    private bool trigger_clicked = false;
    private SteamVR_TrackedObject trackedObj;
    // Use this for initialization
    void Start()
    {

    }
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            trigger_clicked = true;
        }
        else
        {
            trigger_clicked = false;
        }

    }

    //getter setters-------------------------------------------------------------------------------------------------------------------------------------------------
    public bool triggerClicked
    {
        get { return trigger_clicked; }
        set { trigger_clicked = value; }
    }
}
