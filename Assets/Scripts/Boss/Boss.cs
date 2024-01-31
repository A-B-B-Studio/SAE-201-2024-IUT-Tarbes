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

    public float timeToShoot = 2;
    public float randomRange = 1f;

    float chrono = 0;

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
        if (player.position.x > -10)
        {
            if (Input.GetAxis("Fire1") > 0f)
            {
                Instantiate(roche, transform.localPosition, Quaternion.identity);
            }

            chrono += Time.deltaTime;
            if (chrono > timeToShoot)
            {
                Instantiate(roche, transform.localPosition, Quaternion.identity);
                chrono = Random.Range(-randomRange, randomRange);
            }
        }
    }




    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Pas de niveau n�gatif");
        }
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Mort");
        Destroy(gameObject);
    }
}
