using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
	//AudioSource jumpsound; // 추가

	public float movementSpeed = 10f;
	public Text scoreText;
	
	private float movement = 0f;
	private float topScore = 0.0f;
	private Rigidbody2D rb;

    // Use this for initialization
    void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		//jumpsound = GetComponent<AudioSource>(); //추가
	}
	
	// Update is called once per frame
	void Update()
	{
		//jumpsound.Play(); //추가
		movement = Input.GetAxis("Horizontal") * movementSpeed;

		Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
		if (pos.x < 0f) pos.x = 1f; // 왼쪽 끝으로 가면 오른쪽 끝에서 등장 
		if (pos.x > 1f) pos.x = 0f; // 오른쪽 끝으로 가면 왼쪽 끝에서 등장 
		transform.position = Camera.main.ViewportToWorldPoint(pos);

		if (rb.velocity.y > 0 && transform.position.y > topScore)
        {
			topScore = transform.position.y;
        }
        scoreText.text = Mathf.Round(topScore).ToString();
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}