using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
	//private AudioSource jumpsound; //????
	public float jumpForce = 10f;

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
	}

}