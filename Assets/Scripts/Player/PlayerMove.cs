using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 5f;

	private PlayerInput playerInput;
	private InputAction moveAction;

	private Rigidbody2D playerRb;

	private Vector2 moveDirection;

	private void Start()
	{
		playerRb = GetComponent<Rigidbody2D>();

		playerInput = InputProvider.GetPlayerInput();
		if(playerInput != null )
		{
			moveAction = playerInput.actions["Movement"];
		}
	}

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		moveDirection = moveAction.ReadValue<Vector2>();
		if(moveDirection.x > 0 || moveDirection.x < 0)
		{
			playerRb.velocity = new Vector2(moveDirection.x * moveSpeed, playerRb.velocity.y);
		}
	}
}
