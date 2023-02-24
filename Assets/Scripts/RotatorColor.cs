using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorColor : MonoBehaviour
{
    public  Dropdown ColorDropdown;
    public  GameObject rotatorObject;
    void Start()
    {

    }

    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                Rotator.rotatorColor = Color.red;
                break;
            case 2:
                Rotator.rotatorColor = Color.blue;
                break;
            case 3:
                Rotator.rotatorColor = Color.green;
                break;
            default:
                Rotator.rotatorColor = Color.black;
                break;
        }
    }
}
