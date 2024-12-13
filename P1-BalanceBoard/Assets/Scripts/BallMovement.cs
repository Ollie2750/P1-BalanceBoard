using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class BallMovement : MonoBehaviour
{
    private Vector2 input;
    private Rigidbody myBody;
    private Vector3 movement = new Vector3 (0f, 0f, 0f);
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private float maxSpeed;
    private bool isCollidingWithGroundLayer;
    private bool isCollidingWithDeathLayer;

    private void Awake()
    {
        //Sets my = to its component Rigidbody
        myBody = GetComponent<Rigidbody>();
    }

    //Takes the value form the inputsystem and apply it the the Gameobject (The ball/player)
    private void OnMovement(InputValue value)
    {
        //saves the input values Vector2 to input
        //And adds the input value times the speed factor to the movement vector
        input = value.Get<Vector2>();
        movement.x = input.x * speed;
        movement.z = input.y * speed;
    }

    //Rigth stick pressed to jump
    private void OnJump(InputValue value)
    {
        //If the player has to y velocity it will add jumpPower to its y velocity
        if (isCollidingWithGroundLayer)
        {
            myBody.AddForce(new Vector3(0, jumpPower, 0));
        }
        
    }

    private void FixedUpdate()
    {
        // Apply movement force only if the current speed is below the maximum speed
        if (myBody.velocity.magnitude < maxSpeed)
        {
            //Use rigidbody.AddForce to apply the movement vector to the gameobjects velocity
            myBody.AddForce(movement);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is on the "Ground" layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isCollidingWithGroundLayer = true;
        }
       
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Kill"))
            { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Check if the exited collision object is on the "Ground" layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isCollidingWithGroundLayer = false;
        }
    }


}
