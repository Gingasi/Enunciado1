using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise06 : MonoBehaviour
{
    public GameObject Capsule;

    private Material MatCapsule;

    private void Start()
    {
        // Gets the material from the renderer component.
        MatCapsule = Capsule.GetComponent<Renderer>().material;
    }

    // We assign a change color to the capsule
    public void ChangeColor(int index)
    {
        switch (index)
        {
            case 0:
                MatCapsule.color = Color.black;
                break;

            case 1:
                MatCapsule.color = Color.red;
                break;

            case 2:
                MatCapsule.color = Color.white;
                break;

            case 3:
                MatCapsule.color = Color.green;
                break;

            case 4:
                MatCapsule.color = Color.yellow;
                break;

            default:
                MatCapsule.color = Color.blue;
                break;
        }
    }
}
