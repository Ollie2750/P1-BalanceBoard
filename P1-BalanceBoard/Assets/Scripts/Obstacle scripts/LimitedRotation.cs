using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation360 : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    [SerializeField] private float minXRotation = -45f; // Minimum X rotation limit
    [SerializeField] private float maxXRotation = 45f;  // Maximum X rotation limit

    private float currentXRotation = 0f;
    private float direction = 1f; // 1 for forward, -1 for backward

    void Update()
    {
        // Calculate the new rotation on the X-axis
        float deltaX = _rotation.x * _speed * Time.deltaTime * direction;

        // Update the current X rotation value
        currentXRotation += deltaX;

        // Check if the current X rotation exceeds the limits
        if (currentXRotation >= maxXRotation || currentXRotation <= minXRotation)
        {
            direction *= -1; // Reverse direction
        }

        // Apply the rotation
        currentXRotation = Mathf.Clamp(currentXRotation, minXRotation, maxXRotation);
        transform.localEulerAngles = new Vector3(currentXRotation, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}