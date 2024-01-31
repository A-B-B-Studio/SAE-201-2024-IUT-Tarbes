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

    // Le d�lai apr�s lequel le param�tre de d�clenchement sera d�sactiv�
    private float resetTriggerDelay = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = GameObject.FindGameObjectWithTag("AttackAreaPlayerTag");
        attackArea.SetActive(false);

        // R�cup�rez le composant Animator
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

            // D�clenchez l'animation d'attaque
            animator.SetBool("IsAttacking", true);

            timer = 0f;
            attacking = false;

            // D�sactivez le param�tre de d�clenchement apr�s le d�lai sp�cifi�
            StartCoroutine(ResetAttackFlag());
        }
    }

    // Coroutine pour r�initialiser le param�tre de d�clenchement apr�s un d�lai
    IEnumerator ResetAttackFlag()
    {
        yield return new WaitForSeconds(resetTriggerDelay);
        animator.SetBool("IsAttacking", false);
    }
}
