using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 openPos;
    private Vector3 closePos;
    private bool isOpen = false;

    void Start()
    {
        closePos = transform.position;
    }

    public void Activate()
    {
        if (isOpen)
        {
            transform.position = openPos;
        }
        else
        {
            transform.position = closePos;
        }
        isOpen = !isOpen;
    }
}
