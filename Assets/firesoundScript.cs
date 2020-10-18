using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firesoundScript : MonoBehaviour
{
    public AudioSource Sounds;
    public AudioClip fireSound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ghost"))

        {
            Sounds.PlayOneShot(fireSound);
        }
    }
}
