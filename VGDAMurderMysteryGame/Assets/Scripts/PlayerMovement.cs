using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private float xMovement = 0.13f;
    private float yMovement = 0.13f;
    public GameObject dialogueBox;
    public bool menuOpen = false;
    public bool inventoryOpen;
    private AudioSource playerAudioSource;
    private bool playerMovingx = false;
    private bool playerMovingy = false;
    private bool playerMoving = false;
    private Rigidbody2D rb2D;
    public Sprite idleSprite;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        playerAudioSource = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        ///Horizontal movement
        if (Input.GetKey(KeyCode.A) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 270);
            transform.position += new Vector3(-xMovement, 0.0f, 0.0f);
            playerMovingx = true;
        }
        else if (Input.GetKey(KeyCode.D) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 90);
            transform.position += new Vector3(xMovement, 0.0f, 0.0f);
            playerMovingx = true;
        }
        else
        {
            playerMovingx = false;
        }

        ///Vertical movement
        if (Input.GetKey(KeyCode.W) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 180);
            transform.position += new Vector3(0.0f, yMovement, 0.0f);
            playerMovingy = true;
        }
        else if (Input.GetKey(KeyCode.S) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false) 
        {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 0);
            transform.position += new Vector3(0.0f, -yMovement, 0.0f);
            playerMovingy = true;
        }

        else
        {
            playerMovingy = false;
        }
        
        if (playerMovingy == false && playerMovingx == false)
        {
            playerMoving = false;
        }
        else
        {
            playerMoving = true;
        }

        HandlePlayerSound();
        HandlePlayerAnimation();
    }

    private void HandlePlayerSound()
    {
        if (playerMoving == true)
        {
            if (!playerAudioSource.isPlaying)
            {
                playerAudioSource.Play();
            }
        }

        else
        {
            if (playerAudioSource.isPlaying)
            {
                playerAudioSource.Stop();
            }
        }
    }

    private  void HandlePlayerAnimation()
    {
        if (playerMoving == true)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<Animator>().Play("MaggieWalk");
        }
        else
        {
            gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = idleSprite;
        }
    }
}
   
