using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int machineStage = 0;
    public GameObject camera;
    public GameObject circle;
    bool cameraFollow = true;

    //runs when something with a Rigidbody2D enters the trigger
    void OnTriggerEnter2D(Collider2D activator) {
        Debug.Log ("entered");
        bool playerMove = false;
        if (activator.gameObject.tag == "Player") {
            Debug.Log("player entered");
            cameraFollow = false;
            switch (machineStage) {
                case 0:
                    cameraFollow = true;
                    break;

                case 1:
                    camera.GetComponent<Camera>().orthographicSize = 27;
                    camera.transform.position = new Vector3(0f, -19f, -10f);
                    break;

                case 2:
                    camera.GetComponent<Camera>().orthographicSize = 38;
                    camera.transform.position = new Vector3(45f, -112f, -10f);
                    break;

                default:
                    Debug.Log("machineStage out of range");
                    break;

            }
        } else if (activator.gameObject.tag == "ColoredCircle" && !playerMove) {
            circle.GetComponent<ConstantForce2D>().torque = -500f;
            playerMove = true;
        }
    }

    void Update() {
        
        //make sure the camera has something to follow
        if (cameraFollow) {
            camera.transform.position = new Vector3 
                (circle.transform.position.x, circle.transform.position.y, -10f);
        }
    }
}