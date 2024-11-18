using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement_FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0f, 3f, -5f);
    
    void FixedUpdate()
    {
        //Sets the cameras position to the players position plus an offset that can be set in the inspector
        this.transform.position = player.transform.position + offset;
    }
}
