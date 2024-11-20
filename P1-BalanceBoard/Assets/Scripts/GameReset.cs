using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
 
        public float resetThreshold = -20f;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < resetThreshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
