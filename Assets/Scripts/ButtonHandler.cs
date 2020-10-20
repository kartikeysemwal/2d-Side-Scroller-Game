using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerCombat playerCombat;
    bool clicked = false;

    public AudioClip playerAttack;
    AudioSource playerAS;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerCombat = FindObjectOfType<PlayerCombat>();

        playerAS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickJump()
    {
        playerMovement.Jump();
    }

    public void OnClickCrouch()
    {
        playerMovement.crouch = true;
    }

    public void OnClickAttack()
    {
        playerCombat.Attack1();

        playerAS.clip = playerAttack;
        playerAS.Play();
    }

    public void SetUpState()
    {
        playerMovement.crouch = true;
    }

    public void SetDownState()
    {
        playerMovement.crouch = false;
    }
}
