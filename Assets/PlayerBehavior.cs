using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
    
{
    public float speed = 5f;
    public float jumpForce = 10;
    public Rigidbody2D rb2D;
    public float groundedDistance = 2;
    public LayerMask groundedMask;

    bool IsGrounded()
    { 
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundedDistance, groundedMask);

        if (hit.collider == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) 
        {
            rb2D.velocity = jumpForce * Vector2.up;
        }
    }
}
