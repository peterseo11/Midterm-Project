using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("something entered this trigger");
        if (other.gameObject.CompareTag("Ghost"))

        {
            print("Ghost entered");
            ghostScript.ghostAmount += 1;
            Destroy(other.gameObject);
        }
    }
}
