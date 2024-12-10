using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    public GameObject playerPrefab;

    public void Start()
    {
        GameObject newPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}
