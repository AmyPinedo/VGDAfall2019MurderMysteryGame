using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerTransport : MonoBehaviour
{
    private BoxCollider2D bc2D;

    private bool fading = false; 
    
    [SerializeField] private Animator animator;

    [SerializeField] private Vector2 locationToMoveTo;
    
    private void Awake()
    {
        bc2D = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        
        if (player != null && !fading)
        {
            //Debug.Log("Player has entered going to fade out");
            Fade();
            
            StartCoroutine(Transport(player));
        }
        
    }

    public void Fade()
    {
        fading = true;
        animator.SetTrigger("FadeOut");
        //Debug.Log("fading out");
    }

    IEnumerator Transport(PlayerMovement player)
    {       
        yield return new WaitForSeconds(1);
        
        player.transform.position = locationToMoveTo;
        
        animator.SetTrigger("HasMoved");
        //Debug.Log("fading in");
        fading = false;

    }
}
