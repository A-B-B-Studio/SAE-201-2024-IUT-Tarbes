using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caillouxBehavior : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb2D;
    public int damage = 30;
    // Update is called once per frame 
    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + Time.fixedDeltaTime * speed * Vector2.left);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ensemble")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}