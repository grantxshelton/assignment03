using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public Text pinSliderText;
    public Text rotatorSliderText;
    public Slider pinSlider;
    public Slider rotatorSlider;
    public static float pinSliderVal;
    public static float rotatorSliderVal;

    void Start()
    {
        pinSliderVal = 50; // Defaults slider value to 50%
    }
    // Update is called once per frame
    void Update()
    {

        pinSliderVal = ((float)pinSlider.value);
        Pin.speed = pinSlider.value * 2;
        pinSliderText.text = "Pin Speed: " + pinSlider.value.ToString() + "%";

        rotatorSliderVal = ((float)rotatorSlider.value);
        Rotator.speed = rotatorSlider.value * 2;
        rotatorSliderText.text = "Rotator Speed: " + rotatorSlider.value.ToString() + "%";

    }
}
