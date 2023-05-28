using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip eatSound;
    public static AudioClip explosion;
    public static AudioClip health;


    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        eatSound = Resources.Load<AudioClip>("EAT");

        explosion = Resources.Load<AudioClip>("EXPLOSION");
        health = Resources.Load<AudioClip>("HEALTH");


        audioSrc = gameObject.GetComponent<AudioSource>();

    }


    public static void playEatSound()
    {
        audioSrc.PlayOneShot(eatSound);
    }


    public static void playExplosionSound()
    {
        audioSrc.PlayOneShot(explosion);
    }

    public static void playHealthSound()
    {
        audioSrc.PlayOneShot(health);
    }
}


