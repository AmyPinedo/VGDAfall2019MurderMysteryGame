using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour
{
    public Animator animator;

    private int levelToLoad;
    
    private BoxCollider2D bc2D;
    
    void Start()
    {
        bc2D = GetComponent<BoxCollider2D>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        
        Scene CurrentScene = SceneManager.GetActiveScene();

        if (player != null) ;
        {
            FadeToScene();
        }
    }
    
    public void FadeToScene (int levelIndex)
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        
        
        
        animator.SetTrigger("FadeOut");
        
        levelToLoad = levelIndex;
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
