using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Walk : StateMachineBehaviour
{
    private Transform player;
    private Rigidbody2D bossRB;
    private float speed = 1.0f;
    private Boss boss;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    // Get Player position and Boss
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        bossRB = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<Boss>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    // Calc player postion and move boss to this position
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.LookAtPlayer();

        if (player.position.x > -10)
        {
            Vector2 targetPosition = new Vector2(player.position.x, bossRB.position.y);
            Vector2 newPosition = Vector2.MoveTowards(bossRB.position, targetPosition, speed * Time.deltaTime);
            bossRB.MovePosition(newPosition);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
