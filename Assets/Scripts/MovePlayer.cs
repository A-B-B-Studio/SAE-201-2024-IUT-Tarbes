
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vitesseMouv;
    public float jumpForce;

    public bool isJumping = false;
    public bool isGrounded;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;


    // Start is called before the first frame upda

    // Update is called once per frame
    void FixedUpdate()
    {
        float mouvementHorizontal = Input.GetAxis("Horizontal") * vitesseMouv * Time.deltaTime;
        MovePlayer(mouvementHorizontal);

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true; 
        }
    }

    void MovePlayer(float _mouvementHorizontal)
    {
        Vector3 vitesseDuSujet = new Vector2(_mouvementHorizontal, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, vitesseDuSujet, ref velocity, .05f);

        if (isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }
}

