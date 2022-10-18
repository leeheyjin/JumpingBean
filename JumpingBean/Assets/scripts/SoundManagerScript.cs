using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static SoundManagerScript instance;
    [SerializeField]
    private AudioClip jump, collide, item, fall, fire, leaf;
    [SerializeField]
    private AudioSource soundFx, bgMusicSource;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void PlayJump()
    {
        soundFx.PlayOneShot(jump);
    }
    public void PlayCollide()
    {
        soundFx.PlayOneShot(collide);
    }
    public void PlayItem()
    {
        soundFx.PlayOneShot(item);
    }
    public void PlayFall()
    {
        soundFx.PlayOneShot(fall);
    }
    public void PlayFire()
    {
        soundFx.PlayOneShot(fire);
    }
    public void PlayLeaf()
    {
        soundFx.PlayOneShot(leaf);
    }
    public void PlayMusic()
    {
        bgMusicSource.Play();
    }
}
