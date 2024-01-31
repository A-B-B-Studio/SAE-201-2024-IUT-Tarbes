using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    private int damage = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Boss>() != null)
        {
            Boss t = collision.GetComponent<Boss>();
            t.Damage(damage);
        }
    }
}
