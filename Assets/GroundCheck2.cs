﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck2 : MonoBehaviour
{
    public bool isGrounded;

    public void OnTriggerStay2D(Collider2D other)
    {
        isGrounded = true;
    }

    public void OnTriggerExit2D()
    {
        isGrounded = false;
    }
}
