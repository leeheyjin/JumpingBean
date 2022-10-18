using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingPlatform : MonoBehaviour
{
	public float jumpForce = 10f;
	EdgeCollider2D edge;

	void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.relativeVelocity.y <= 0f)
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}

		if (collision.gameObject.tag == "Bean")
        {
			SoundManagerScript.instance.PlayCollide(); //Ãß°¡
			edge = GetComponent<EdgeCollider2D>();
			Destroy(edge);
        }
	}
}
