using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class LayerCollisionKill : MonoBehaviour
{
    // Set the "Killer" layer number
    private int KillLayer;

    private void Start()
    {
        // Get the "Killer" layer number based on the layer's name
        KillLayer = LayerMask.NameToLayer("Kill");
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is on the "Killer" layer
        if (collision.gameObject.layer == KillLayer)
        {
            // Destroy the player object
            Destroy(gameObject);

            Debug.Log("You Died");
        }
    }
}
