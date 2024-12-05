using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 openPos;
    private Vector3 closePos;
    private bool isOpen = false;
    public float transitionSpeed;
    public float doorTimer;
    
    void Start()
    {
        closePos = transform.position;
    }

    public void Activate()
    {
        Debug.Log("buttonpress");
        if (!isOpen)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        StopAllCoroutines();
        StartCoroutine(DoorTransition(openPos));
        isOpen = true;
        StartCountdown(doorTimer, CloseDoor);

    }

    private void CloseDoor()
    {
        StartCoroutine(DoorTransition(closePos));
        isOpen = false;
    }

    public IEnumerator DoorTransition(Vector3 targetPosition)
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * transitionSpeed);
            yield return null;
        }

        transform.position = targetPosition;
    }

    public void StartCountdown(float duration, System.Action onComplete)
    {
        StartCoroutine(Countdown(duration, onComplete));
    }

    private IEnumerator Countdown(float duration, System.Action onComplete)
    {
        float timer = duration;
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            yield return null;
        }
        onComplete?.Invoke();
    }
}
