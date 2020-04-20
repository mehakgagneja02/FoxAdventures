using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController controller;
	public Animator animator;
	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("speed",Mathf.Abs(horizontalMove ) );

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("isjumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

	}
	//public void OnCrouching(bool iscrouching)
	//{
	//	animator.SetBool("iscrouching", iscrouching);
		
	//}
	public void OnLanding()
	{
		animator.SetBool("isjumping", false);
	}

	
	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}