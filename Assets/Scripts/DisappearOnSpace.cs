using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnSpace : MonoBehaviour
{

    void Update() //Destroys this GameObject and its children if space is pressed
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            for (int i = this.transform.childCount - 1; i >= 0; i--)
                GameObject.Destroy(this.transform.GetChild(i).gameObject);
            Destroy(this.gameObject);
        }
    }
}