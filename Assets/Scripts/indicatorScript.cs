using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class indicatorScript : MonoBehaviour
{
    public GameObject indicator;
    private ARRaycastManager aRRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject button;
    public GameObject objectToPlace;
    private GameObject placedObject;

    // Start is called before the first frame update
    void Start()
    {
        aRRaycastManager = FindAnyObjectByType<ARRaycastManager>();

        if (aRRaycastManager == null)
        { Debug.Log("AR raycast manager not found"); return; }

       // indicator = indicator.transform.GetChild(0).gameObject;
        indicator.SetActive(true);

        button.SetActive(true);
    }

    // Update is called once per frame
    void Update()                   
    {
        var ray = new Vector2(Screen.width / 2, Screen.height / 2);

        if (aRRaycastManager.Raycast(ray, hits, TrackableType.Planes))
        {
            Pose hitPose = hits[0].pose;
            indicator.transform.position = hitPose.position;
            indicator.transform.rotation = hitPose.rotation;

            //if (!indicator.activeInHierarchy)
            //{ indicator.SetActive(true); }
        
        }
    }


    public void placeButton()               //when the user presses the   button this  function gets called
        {

        button.SetActive(false);
        placedObject = Instantiate(objectToPlace, indicator.transform.position, indicator.transform.rotation);
        indicator.SetActive(false);
        }
}
