using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    public GameObject laserPrefab;
    private GameObject laser; 
    private Transform laserTransform;
    private Vector3 hitPoint;
    private GameObject obj;
    private bool laserSelection;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>(); 
    }

    //displays laser
    private void ShowLaser(RaycastHit hit)
    {
        laser.SetActive(true);
        laserTransform.position = Vector3.Lerp(trackedObj.transform.position, hitPoint, .5f);
        laserTransform.LookAt(hitPoint);
        laserTransform.localScale = new Vector3(laserTransform.localScale.x, laserTransform.localScale.y, hit.distance);
    }

	// Use this for initialization
	void Start () {
        laser = Instantiate(laserPrefab);
        laserTransform = laser.transform;
        laserSelection = false;
	}
	
	// Update is called once per frame
	void Update () {
        //checks if user hits collider
		if (Controller.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            RaycastHit hit;
            if (Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 100))
            {
                Debug.Log(hit.collider.gameObject.name);
                obj = hit.collider.gameObject;
                hitPoint = hit.point;
                ShowLaser(hit);
                laserSelection = true;
            }
        }
        else
        {
            laser.SetActive(false);
        }
	}

    //getter setters--------------------------------------------------------------------------------------------------------------------------------------------------
    public GameObject hitObject{
       get { return obj; }
        set { obj = value;}
    }

    public bool laserHit
    {
        get
        { return laserSelection; }
        set
        {
            laserSelection = value;
        }
    }
}

//www.raywenderlich.com/149239/htc-vive-tutorial-unity

