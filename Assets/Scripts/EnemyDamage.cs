using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage;
    public float damageRate;
    public float pushBackForce;

    float nextDamage;

    // Start is called before the first frame update
    void Start()
    {
        nextDamage = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Occured");
        if (collision.tag == "Player" && nextDamage < Time.time)
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damage);
            nextDamage = Time.time + damageRate;

            PushBack(collision.transform);
        }
    }

    void PushBack(Transform pushedObject)
    {
        Vector2 pushDirection = new Vector2(0, (pushedObject.position.y - transform.position.y)).normalized;
        pushDirection = pushDirection * pushBackForce;
        Rigidbody2D rigidbody2D = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.zero;
        Debug.Log(pushDirection);
        rigidbody2D.AddForce(pushDirection, ForceMode2D.Impulse);
    }
}
