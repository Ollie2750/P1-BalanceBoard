using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesseperingPlatform : MonoBehaviour
{
    public GameObject platform;
    private float n = 1f;
    private bool active = false;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
        if (other.tag == "Player")
        {
            Debug.Log("Player");
            active = true;
        }
            
    }

    private void FixedUpdate()
    {
        if (active)
        {
            n -= .01f;
            platform.GetComponent<Renderer>().material.color = new Color(0,0,0,n);
            if (n <= 0f)
            {
                platform.SetActive(false);
                active = false;
            }
        }
        else if (!active)
        {
            if (n >= 1f)
            {
                platform.SetActive(true);
                platform.GetComponent<Renderer>().material.color = new Color(0, 0, 0, n);
            }
            else
            {
                n += .02f;
            }
        }
    }
}
