using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //linear camera movement
        transform.position = new Vector3
            (circle.transform.position.x, circle.transform.position.y, -10);
    }
}
