using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private int speed = 5;
    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMovement(InputValue value){
        movement = value.Get<Vector2>();
    }

    private void FixedUpdate(){
        //test number thirty two
        if (movement.x !=0 || movement.y !=0){
            //rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
            //rb.velocity = movement * speed;
            rb.AddForce(movement * speed);
        }
  
    

    }
}
