using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;

    // We established between wich numbers we are going to change the text.
    private int minNum = 0;
    private int maxNum = 100;

    //With a public void we indicate that once we press the button a random number will be generated
    public void GenerateRandomNumber()
    {
        
        textTMP.text = Random.Range(minNum, maxNum).ToString();
    }
}
