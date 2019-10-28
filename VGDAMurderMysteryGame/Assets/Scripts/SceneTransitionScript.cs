using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour
{
    public Animator animator;

    private int areaToLoad;
    
    private BoxCollider2D bc2D;
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        bc2D = GetComponent<BoxCollider2D>();
        
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if (player != null) ;
        {
            Fade();
        }
    }
    
    public void Fade ()
    {
        
        animator.SetTrigger("FadeOut");
        
    }

    
}
