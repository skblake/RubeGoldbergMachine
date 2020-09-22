using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform cameraTransform; 
    Transform cameraFocusTarget;

    //runs when something with a Rigidbody2D enters the trigger
    void OnTriggerEnter2D(Collider2D activator) {

        //often using activator.name like this is useful for debugging
        //notice that "activator" is just the name of the parameter
        Debug.Log(activator.name + " entered this trigger!");

        //start camera following this object
        cameraFocusTarget = activator.transform; 
    }

    //runs when something with a Rigidbody2D exits the trigger
    void OnTriggerExit2D(Collider2D activator) {

        //if this object exited the trigger, stop making the camera
        //follow it.
        if (activator.transform == cameraFocusTarget)
            cameraFocusTarget = null;
    }

    void Update() {
        
        //make sure the camera has something to follow
        if (cameraFocusTarget != null) {
            //move the camera to focus the object that entered the trigger, 
            //every frame
            cameraTransform.position = cameraFocusTarget.position +
                new Vector3(0f, 0f, -10f);
        }
    }
}