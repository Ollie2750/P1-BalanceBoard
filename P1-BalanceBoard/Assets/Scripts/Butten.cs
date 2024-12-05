using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butten : MonoBehaviour
{
    [SerializeField] private Elevator elevator;
    [SerializeField] private Door door;
    
    private void OnTriggerEnter()
    {
        if (elevator != null)
        {
            elevator.activate();
        }

        if (door != null)
        {
            door.Activate();
        }        
    }

    

}
