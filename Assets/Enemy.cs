using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

   public void TakeDamage(int damage)
   {
       animator.SetTrigger("Hurt");

       currentHealth -=damage;
       if(currentHealth<=0)
       {
           Die();
       }
   }

   void Die()
   {
       animator.SetBool("IsDead", true);

       GetComponent<Collider>().enabled = false;
       this.enabled = false;
   }
}
