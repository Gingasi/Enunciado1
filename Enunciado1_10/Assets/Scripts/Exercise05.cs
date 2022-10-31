using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public GameObject Capsules;
    public Vector3[] positions;

    void Update()
    {
        CapsuleArray(); // I've done a function so its easy and the game does'nt have to be constantly checking if S is being pressed. 
    }

    void CapsuleArray()
    {
        // If the S key is pressed a capsule appears on the array position already stablished on the inspector
        if (Input.GetKeyDown(KeyCode.S))
        {

            GameObject[] capsulesInGame = GameObject.FindGameObjectsWithTag("Capsules");


            foreach (GameObject obj in capsulesInGame)
            {
                Destroy(obj);
            }


            foreach (Vector3 pos in positions)
            {
                Instantiate(Capsules, pos, Capsules.transform.rotation);
            }
        }
    }
}
