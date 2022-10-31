using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI counter;

    private int score = 0;

    public GameObject balls;

    private void Start()
    {
        // Everytime you start a new game it resets to zero.
        counter.text = score.ToString();
    }

        //It supposed to destroy each ball everytime you clicked on it. also activates the Add Point Variable.
    private void OnCollisionEnter(Collision otherCollider)
    {
       
      if (Input.GetMouseButtonDown(0))
        {
            if (otherCollider.gameObject.CompareTag("Balls"))
            {
                Destroy(gameObject);
                AddPoint();
            }
        }
    }
 

    // Adds +1 point.
    public void AddPoint()
    {
        score++;
        counter.text = score.ToString();
    }
}
