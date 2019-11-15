using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerTransport : MonoBehaviour
{
    private BoxCollider2D bc2D;
    
    [SerializeField] private Animator animator;

    [SerializeField] private Vector2 locationToMoveTo;
    
    private void Awake()
    {
        bc2D = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        
        if (player != null)
        {
            Fade();
            
            StartCoroutine(Transport(player));
        }
        
    }

    public void Fade()
    {
        animator.SetTrigger("FadeOut");
    }

    IEnumerator Transport(PlayerMovement player)
    {       
        yield return new WaitForSeconds(1);
        
        player.transform.position = locationToMoveTo;
        
        animator.SetTrigger("HasMoved");
        
    }
}
