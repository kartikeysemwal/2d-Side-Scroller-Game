using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public PlayerHealth playerHealth;

    public void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        //if (slider.value == 0)
        //{
          //  playerHealth.run = true;
            //playerHealth.Death();
        //}
    }

    public void Update()
    {
        //Debug.Log(slider.value);
    }
}
