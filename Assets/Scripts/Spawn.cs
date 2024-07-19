using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;

public class Spawn : MonoBehaviour
{
    public GameObject GalleryObject;
    public GameObject indicator;
    [Header("Positions")]
    [SerializeField] float x1, x2,x3,x4 = 0;
    [SerializeField] float y1, y2, y3, y4 = 0;
    public int n = 0;
    

    [SerializeField] Vector3[] cornerPositions = new Vector3[4]; // Store corner positi
    public ARRaycastManager raycastManager;

    void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
        if (raycastManager == null)
        {

            Debug.Log("AR raycast manager NOT FOUND");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 averageCenter()
    {
        Vector3 sum = Vector3.zero;
        foreach (Vector3 cornerPosition in cornerPositions)
        {
            sum += cornerPosition;
        }

        return sum / cornerPositions.Length;
    }

    public void buttonPressVal()
    {
        if (n == 0) { }//store val of first corner
        if (n == 1) { }
        if (n == 2) { }
        if (n == 3) { }
        n += 1;

    }
}
