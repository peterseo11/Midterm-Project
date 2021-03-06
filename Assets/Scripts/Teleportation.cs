﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Player;
    public AudioSource Sounds;
    public AudioClip playerDead;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            Sounds.PlayOneShot(playerDead);
            StartCoroutine (Teleport ());  
        }
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(1);
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    }
}
