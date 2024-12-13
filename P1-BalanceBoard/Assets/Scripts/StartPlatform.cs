using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    public GameObject playerPrefab;
    private Vector3 Checkpoint;

    public void Start()
    {
        Checkpoint = transform.position;
        SpawnPlayer();
        
    }

    public void SpawnPlayer()
    {
        GameObject newPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }

    public void OpretCheckpoint(Vector3 checkpointPosition)
    {
        Checkpoint = checkpointPosition;
        Debug.Log("nyt checkpoint lavet :))");
    }
}