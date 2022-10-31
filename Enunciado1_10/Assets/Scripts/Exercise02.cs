using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    public int number;

    void Update()
    {
        // Pressing the spacebar, verifies whether the inserted number is odd or even.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // then we divide by 2 and if the division goes to zero then its even. Else then the number woul be odd.
            if (number % 2 == 0)
            {
                
                textTMP.text = "Number: " + number + " is EVEN";
            }
            else
            {
                
                textTMP.text = "Number: " + number + " is ODD";
            }
        }
    }
}
