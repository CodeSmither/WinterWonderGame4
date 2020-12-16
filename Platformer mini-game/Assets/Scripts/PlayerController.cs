using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	Rigidbody2D rb;
	float dirX, moveSpeed = 5f;


	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;

		if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
			rb.AddForce(Vector2.up * 300f);
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(dirX, rb.velocity.y);
	}
}