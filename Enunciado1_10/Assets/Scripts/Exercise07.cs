using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{
    public GameObject sphere;

    private Material GastlyMat;

    private void Start() // Find the material.
    {
        GastlyMat = sphere.GetComponent<Renderer>().material;
    }

    // We increase or decrease opacity value throug the slider.
    public void ChangeGastlyAlpha(float value)
    {
        GastlyMat.color = new Vector4(GastlyMat.color.r, GastlyMat.color.g, GastlyMat.color.b, value);
    }
}
