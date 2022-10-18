using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burning : MonoBehaviour
{
    public GameObject gameoverPanel;
    SpriteRenderer sprite;
    BoxCollider2D box;

    void Start()
    {
        gameoverPanel.SetActive(false);
        Time.timeScale = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            SoundManagerScript.instance.PlayFire(); 
            sprite = GetComponent<SpriteRenderer>();
            sprite.material.color = new Color(0.5f, 0.5f, 0.5f, 1f);

            box = GetComponent<BoxCollider2D>();
            box.enabled = !box.enabled;

            gameoverPanel.SetActive(true);

            Time.timeScale = 1;
        }

        if (collision.gameObject.tag == "Worm")
        {
            box = GetComponent<BoxCollider2D>();
            box.enabled = !box.enabled;

            gameoverPanel.SetActive(true);
            Time.timeScale = 1;
        }

        if (collision.gameObject.tag == "Floor")
        {
            gameoverPanel.SetActive(true);
            Time.timeScale = 1;
        }
    }
}