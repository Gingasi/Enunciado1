using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise09 : MonoBehaviour
{
    public Toggle Lights;
    public GameObject PointLight;

    private void Start()
    {
        // Default state according to toggle value.
        SwitchLight(Lights.isOn);
    }

    // Turn the light on and off.
    public void SwitchLight(bool isOn)
    {
        // If is ON
        if (isOn)
        {
            // Lights On.
            PointLight.GetComponent<Light>().enabled = true;
            Debug.Log("Light is On");
        }
        else
        {
            // Lights Off.
            PointLight.GetComponent<Light>().enabled = false;
            Debug.Log("Light is Off");
        }
    }
}
