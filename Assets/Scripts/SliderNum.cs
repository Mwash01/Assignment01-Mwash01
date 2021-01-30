using UnityEngine;
using UnityEngine.UI;

public class SliderNum : MonoBehaviour
{
    public Slider slider;
    public Text sliderValue;


    void Update()
    {
        sliderValue.text = slider.value.ToString("0");
    }
}
