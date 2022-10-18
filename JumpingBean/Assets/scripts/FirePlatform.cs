using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlatform : MonoBehaviour
{
	public float jumpForce = 5f;
	EdgeCollider2D edge;


	private void Start()
	{
		//jumpsound = GetComponent<AudioSource>(); //????
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f)
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				SoundManagerScript.instance.PlayJump(); //????
														//jumpsound.Play(); //????
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}

		if (collision.gameObject.tag == "Bean")
		{
			SoundManagerScript.instance.PlayCollide(); //????
			edge = GetComponent<EdgeCollider2D>();
			Destroy(edge);
		}
	}
}
