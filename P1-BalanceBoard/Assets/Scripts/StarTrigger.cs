using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTrigger : MonoBehaviour
{
    [SerializeField] private int level;
    [SerializeField] private int number;

    private void OnTriggerEnter()
    {
        StarsCollected.newStar(level, number);
        Destroy(gameObject);
    }
}
