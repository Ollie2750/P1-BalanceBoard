using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionKiller : MonoBehaviour
{
    // This method is called when the Collider attached to this object 
    // collides with another Collider.
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the player object
            Destroy(collision.gameObject);

            Debug.Log("You died");
        }
    }
}
