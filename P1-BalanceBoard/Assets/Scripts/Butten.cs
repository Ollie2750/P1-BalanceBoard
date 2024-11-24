using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butten : MonoBehaviour
{
    [SerializeField] private Elevator elevator;
    private void OnTriggerEnter()
    {
        elevator.activate();
    }
}
