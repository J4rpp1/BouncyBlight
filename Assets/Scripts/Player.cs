using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 20;
    public float gravity = -9.81f;
    public bool isGrounded;
    public bool CanMove;
    public Rigidbody2D rb;
    public LayerMask groundLayers;
   
    
    void Start()
    {
        CanMove = true;
    }


    void Update()
    {
        
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f),
            new Vector2(transform.position.x + 0.5f, transform.position.y - 0.51f), groundLayers);

        if (CanMove)
        {
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        }

        if(isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,1f) * JumpForce, ForceMode2D.Impulse);
        }
       
    }
}