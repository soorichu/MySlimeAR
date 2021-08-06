using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Popping : MonoBehaviour
{
    public ARPlaneManager arPlaneManager;
    public ARRaycastManager arRaycastManager;

    public GameObject placePrefab;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPos = Input.GetTouch(0).position;
            if(arRaycastManager.Raycast(touchPos, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;
                Instantiate(placePrefab, hitPose.position, hitPose.rotation);
            }
        }
    }
}
