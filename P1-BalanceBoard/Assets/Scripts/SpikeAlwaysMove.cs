using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAlwaysMove : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed = 1f;

    private Vector3 targetPosition;
    private bool isMoving = false;

    void Start()
    {
        targetPosition = pointB.position;
    }
    private void FixedUpdate()
    {
        StartMoving();
    }

    public void StartMoving()
    {
        if (!isMoving)
        {
            isMoving = true;
            targetPosition = pointB.position; // Reset target position to pointB
            StartCoroutine(MoveObject());
        }
    }

    private IEnumerator MoveObject()
    {
        while (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Check if the object has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                if (targetPosition == pointB.position)
                {
                    // Switch target position
                    targetPosition = pointA.position;
                    UnityEngine.Debug.Log("Reached Point B, moving to Point A");
                }
                else
                {
                    isMoving = false;
                    UnityEngine.Debug.Log("Reached Point A");
                }
            }
                // Wait for the next frame
                yield return null;
            
            }
        }
    }

