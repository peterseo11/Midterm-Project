using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ghostScript : MonoBehaviour
{
    Text ghostText;
    public static int ghostAmount;
    void Start()
    {
        ghostText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        ghostText.text = ghostAmount.ToString();
    }
}
