
using UnityEngine;

public class playerbehaviour : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 7;
    public Rigidbody2D rb2b;
    public float groundedDistance = 2f;
    public LayerMask groundedMask;

    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundedDistance, groundedMask);
        
        if (hit.collider != null)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb2b.velocity = jumpForce * Vector2.up;
        }
    }
}
