using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 20;
    public float gravity = -9.81f;
    private bool isGrounded;
    
    void Start()
    {
        
    }


    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}