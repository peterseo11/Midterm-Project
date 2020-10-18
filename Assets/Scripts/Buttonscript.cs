using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonscript : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject destroyTarget;
    public AudioSource Sounds;
    public AudioClip pressurePlate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (destroyTarget != null)
        {
            Sounds.PlayOneShot(pressurePlate);
            Destroy(destroyTarget);
        }

    }
}
