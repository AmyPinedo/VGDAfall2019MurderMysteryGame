using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    private BoxCollider2D bc2D;
    private AudioSource audio;

    private void Awake()
    {
        bc2D = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        audio = GetComponent<AudioSource>();
        
        if (player != null && !audio.isPlaying)
        {
            audio.Play();
        }
    }
}
