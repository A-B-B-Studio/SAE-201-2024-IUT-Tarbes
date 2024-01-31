using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Tuto Unity Fr*/
public class SanteJoueur : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public barreHp BarreHp;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        BarreHp.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        BarreHp.SetHealth(currentHealth);
    }
}
