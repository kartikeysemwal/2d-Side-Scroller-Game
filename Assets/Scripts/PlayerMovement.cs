using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    public Animator animator;
    float value;

    // Start is called before the first frame update

    float horizontalMove = 0f;
    bool jump = false;
    public bool crouch = false;
    bool roll = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = CrossPlatformInputManager.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    public void Jump()
    {
        jump = true;
        animator.SetBool("IsJumping", true);
    }

    public void Crouch()
    {
        
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
