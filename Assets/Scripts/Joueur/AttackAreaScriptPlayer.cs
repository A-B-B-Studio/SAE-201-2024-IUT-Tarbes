using System.Collections;
using UnityEngine;

public class AttackAreaScript : MonoBehaviour
{
    private GameObject attackArea;
    private bool attacking;
    private float timeToAttack = 0.25f;
    private float timer;
    private float betweenSetActiveCooldown;
    private Animator animator;

    // Le délai après lequel le paramètre de déclenchement sera désactivé
    private float resetTriggerDelay = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = GameObject.FindGameObjectWithTag("AttackAreaPlayerTag");
        attackArea.SetActive(false);

        // Récupérez le composant Animator
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        betweenSetActiveCooldown += Time.deltaTime;
        timer += Time.deltaTime;
    }

    private void Attack()
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

            // Déclenchez l'animation d'attaque
            animator.SetBool("IsAttacking", true);

            timer = 0f;
            attacking = false;

            // Désactivez le paramètre de déclenchement après le délai spécifié
            StartCoroutine(ResetAttackFlag());
        }
    }

    // Coroutine pour réinitialiser le paramètre de déclenchement après un délai
    IEnumerator ResetAttackFlag()
    {
        yield return new WaitForSeconds(resetTriggerDelay);
        animator.SetBool("IsAttacking", false);
    }
}
