using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartPlatform startPlatform = FindObjectOfType<StartPlatform>();
            if (startPlatform != null)
            {
                startPlatform.OpretCheckpoint(transform.position);

            }
        }
    }
}
