// Written by Jay Gunderson
// 02/13/2025
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    // Variables
    protected GameObject paddleGo;
    protected Vector3 moveDirection = Vector3.zero;
    [SerializeField, Range(1,20)]protected float moveSpeed = 1f;
   // [SerializeField, Range(10, 29)] protected float maxSpeed = 25f;
    // Methods

    private void Update()
    {
        MovePaddle();

    }


    // Input from action
    public void MovePaddle(InputAction.CallbackContext aContext)
    {
        Vector2 av2 = aContext.ReadValue<Vector2>();
        
        moveDirection.x = av2.x;
        moveDirection.y = av2.y;
    }

    // Moves player paddle
    public void MovePaddle()
    {
       
      transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
      
    }

}
