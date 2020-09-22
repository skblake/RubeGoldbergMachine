using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleColor : MonoBehaviour
{
    
    Color yellow = colorMaker (255, 215, 59);
    Color orange = colorMaker (255, 135, 0);
    Color red = colorMaker (255, 63, 0); 

    //Assign the object a random color from the color palette 
    void Start()
    {
        int colorNum = (int)Random.Range(1, 4);

        switch (colorNum) {
            case 1:
                gameObject.GetComponent<SpriteRenderer>().color = yellow;
                break;
                
            case 2:
                gameObject.GetComponent<SpriteRenderer>().color = orange;
                break;

            case 3:
                gameObject.GetComponent<SpriteRenderer>().color = red;
                break;
        }
        
    }

    static Color colorMaker (float n1, float n2, float n3) {
        return new Color(n1/255, n2/255, n3/255);
    }

}