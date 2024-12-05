using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] private Vector3 startingPosition = new Vector3(0,0,0);
    [SerializeField] private Vector3 endPosition = new Vector3(0, 0, 0);
    private Vector3 dirrection1;
    private Vector3 dirrection2;
    private Vector3 currentDirrection;
    private bool moving = false;
    [SerializeField] private int speed;

    void Start()
    {
        transform.position = startingPosition;
        dirrection1 = endPosition - startingPosition;
        dirrection2 = startingPosition - endPosition;

    }

    void FixedUpdate()
    {
        if (moving)
        {
            transform.position += currentDirrection / speed;
        }
        if ((transform.position - startingPosition).magnitude < 0.01f || (transform.position - endPosition).magnitude < 0.01f)
        {
            if ((transform.position - startingPosition).magnitude < 0.01f)
            {
                transform .position = startingPosition;
            }
            if ((transform.position - endPosition).magnitude < 0.01f)
            {
                transform .position = endPosition;
            }
            moving = false;
        }

    }

    public void activate()
    {
        if (transform.position == startingPosition)
        {
            moving = true;
            currentDirrection = dirrection1;
        } 
        else if (transform.position == endPosition) 
        {
            moving = true;
            currentDirrection = dirrection2;
        }
        
    }
}
