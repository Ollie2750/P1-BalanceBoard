using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallMovement : MonoBehaviour
{
    private Vector2 input;
    private Rigidbody myBody;
    private Vector3 movement = new Vector3 (0f, 0f, 0f);
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;

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
        if (myBody.velocity.y == 0)
        {
            myBody.AddForce(new Vector3(0, jumpPower, 0));
        }
        
    }

    private void FixedUpdate()
    {
        //Use rigidbody.AddForce to apply the movement vector to the gameobjects velocity
        myBody.AddForce(movement);

    }
}
