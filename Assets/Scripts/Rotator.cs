using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public static float speed = 100;
    public GameObject rotatorObject;
    public static Color rotatorColor = Color.black;

    // Update is called once per frame
    void Update()
    {
        //(speed * (SliderChange.rotatorSliderVal/100)
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
        
        if(rotatorColor != null)
            rotatorObject.GetComponent<SpriteRenderer>().color = rotatorColor;
        else
            rotatorObject.GetComponent<SpriteRenderer>().color = Color.black;

    }
}
