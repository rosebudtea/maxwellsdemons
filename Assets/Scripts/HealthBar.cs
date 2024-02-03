using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetHealth(int health)
    {
        Debug.Log("Set Health to: " +  health);
        slider.value = health;
    }

    public void SetMaxHealth(int health)
    {
        Debug.Log("Set Max Health to: " + health);
        slider.maxValue = health;
        slider.value = health;
    }
}
