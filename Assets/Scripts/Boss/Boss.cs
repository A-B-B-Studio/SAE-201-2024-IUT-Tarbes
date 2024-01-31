using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Transform player;
    private bool isFlipped = false;

    public int MaxHealth = 200;
    public int currentHealth;
    public GameObject roche;

    private void Start()
    {
        currentHealth = MaxHealth; 
    }

    public void LookAtPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;

        }
        
        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.Rotate(0f, 0f, 0f);
            isFlipped = false;
        }
    }

    void Update()
    {
        if (Input.GetAxis("Fire1") > 0f)
        {
            Instantiate(roche, transform.localPosition, Quaternion.identity);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
        }
    }
}
