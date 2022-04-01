using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = .5f;
    public LayerMask enemyLayers;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    public int attackDamage = 40;
    void Update()
    {
        if(Time.time>=nextAttackTime)
        {
            if(Input.GetKeyDown("mouse 0"))
        {

            Attack();
            nextAttackTime = Time.time + 1f/attackRate;
        }


        }
        
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider enemy in hitEnemies)
        
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }

    }

    void OnDrawGizomosSelected()
    {
        if(attackPoint == null)
        {
        return;
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(attackPoint.position, attackRange);
    }

}
