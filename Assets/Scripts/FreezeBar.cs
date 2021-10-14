using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FreezeBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxFreeze(float FreezeLevel)
    {
        slider.maxValue = FreezeLevel;
        slider.value = FreezeLevel;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetFreeze(float Freezelevel)
    {
        slider.value = Freezelevel;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
   