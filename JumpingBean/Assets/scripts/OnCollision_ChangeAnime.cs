using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 충돌하면 애니메이션을 전환한다 
public class OnCollision_ChangeAnime : MonoBehaviour
{
	public string normalAnime = ""; // 보통 애니메이션 ：Inspector에 지정
	public string nextAnime = "";   // 다음 애니메이션 ：Inspector에 지정

	void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
	{ 
		// 만약 충돌한 것의 이름이 목표 오브젝트면
		if (collision.gameObject.tag == "Bean")
		{
			Animator animator = this.GetComponent<Animator>();
			animator.Play(nextAnime); 
		}
	}
}
