using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 2f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.F))
        {
            Attack1();
        }
        if (Input.GetButtonDown("Fire2") || Input.GetKeyDown(KeyCode.G))
        {
            Attack2();
        }
        if (Input.GetButtonDown("Fire3") || Input.GetKeyDown(KeyCode.V))
        {
            Attack3();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Rolling();
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Sliding();
        }*/
    }

    void Shoot()
    {

    }

    public void Attack1()
    {
        animator.SetTrigger("IsAttacking1");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.transform.GetChild(0).gameObject.name);
            if(enemy.transform.GetChild(0).gameObject.name == "simpleAICreature")
            {
            enemy.transform.GetChild(0).gameObject.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
            }
            else
            {
                enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
            }
        }
    }
    void Attack2()
    {
        animator.SetTrigger("IsAttacking2");
    }
    
    void Attack3()
    {
        animator.SetTrigger("IsAttacking3");
    }

    void Rolling()
    {
        animator.SetTrigger("IsRolling");
    }

    void Sliding()
    {
        animator.SetTrigger("IsSliding");
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}


