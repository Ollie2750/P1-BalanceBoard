using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMoveScript : MonoBehaviour
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

    public void StartMoving()
    {
        if (!isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveObject());
        }
    }

    private IEnumerator MoveObject()
    {
        while (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Check if the object has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                // Switch target position
               targetPosition = pointA.position;
            }
            else
            {
                isMoving = false;
                UnityEngine.Debug.Log("Reached Point A");
            }

            // Wait for the next frame
            yield return null;
        }
    }

}
