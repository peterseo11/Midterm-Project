using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public GameObject brush;
    public GameObject stamp;


    public float maxRaycastDistance = 1000f;

    // Update is called once per frame
    void Update()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D mouseHit = Physics2D.Raycast(camRay.origin, camRay.direction, maxRaycastDistance);

        if (mouseHit.collider != null)
        {
            if (mouseHit.collider.tag == ("paper"))
            {
                brush.SetActive(true);
                brush.transform.position = mouseHit.point;
            }
        }

        if (Input.GetMouseButton(0))
        {
            GameObject thisStamp = Instantiate(stamp, mouseHit.point, Quaternion.identity);
            //thisStamp.transform.SetParent(mouseHit.transform, true);
        }
    }
}
