using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;

    public float maxHealth = 100f;
    public float currentHealth;

    public HealthBar healthBar;
    public bool run = false;

    public GameObject deathFX;
    public GameObject damageFX;

    public AudioClip playerHurt;
    AudioSource playerAS;

    PauseMenu pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        playerAS = GetComponent<AudioSource>();
        pauseMenu = FindObjectOfType<PauseMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && run == false)
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(float damage)
    {
        Instantiate(damageFX, transform.position + new Vector3(0, 0, -4), transform.rotation);
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth != 0)
        {
            playerAS.clip = playerHurt;
            playerAS.Play();
        }

        if(currentHealth == 0)
        {
            Death();
            Debug.Log("In take damage");
        }
    }

    public void Death()
    {
        Instantiate(deathFX, transform.position + new Vector3(0, 0, -4), transform.rotation);
        Debug.Log(transform.position);
        animator.SetBool("IsDead", true);
        Debug.Log("In death function");
        Destroy(gameObject);

        pauseMenu.LoadMenu();
        
        /*if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("PlayerDeath"))
        {
            Destroy(gameObject);
        }*/

        //GetComponent<Collider2D>().enabled = false;
        //this.enabled = false;
    }
}
