using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAreaScript : MonoBehaviour
{
    private GameObject attackArea;
    private bool attacking;
    private float timeToAttack = 0.25f;
    private float timer;
    private float betweenSetActiveCooldown;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = GameObject.FindGameObjectWithTag("AttackAreaPlayerTag");
        attackArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        betweenSetActiveCooldown += Time.deltaTime;
        timer += Time.deltaTime;
    }

    private void Attack ()
    {
        if (betweenSetActiveCooldown >= 0.25f)
        {
            attackArea.SetActive(false);
            betweenSetActiveCooldown = 0f;
        }

        if (timer < timeToAttack)
        {
            attacking = false;
        }
        else
        {
            attacking = true;
        }

        if (Input.GetKeyDown(KeyCode.Y) && attacking)
        {
            attackArea.SetActive(true);
            

            timer = 0f;

            attacking = false;
        }
    }
}