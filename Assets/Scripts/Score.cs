using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public AudioSource Sounds;
    public AudioClip ghostGet;
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("something entered this trigger");
        if (other.gameObject.CompareTag("Ghost"))

        {
            print("Ghost entered");
            ghostScript.ghostAmount += 1;
            Sounds.PlayOneShot(ghostGet);
            Destroy(other.gameObject);
        }
    }
}
