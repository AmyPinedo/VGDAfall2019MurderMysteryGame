using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private float xMovement = 0.2f;
    private float yMovement = 0.2f;
    public GameObject dialogueBox;
    public bool menuOpen = false;
    public bool inventoryOpen;
    private AudioSource playerAudioSource;
    private bool playerMoving = false;
    private Rigidbody2D rb2D;

    private void Awake()
    {
        playerAudioSource = GetComponent<AudioSource>();
        rb2D = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        ///Horizontal movement
        if (Input.GetKey(KeyCode.A) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.position += new Vector3(-xMovement, 0.0f, 0.0f);
            playerMoving = true;
        }
        else if (Input.GetKey(KeyCode.D) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.position += new Vector3(xMovement, 0.0f, 0.0f);
            playerMoving = true;
        }

        ///Vertical movement
        else if (Input.GetKey(KeyCode.W) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.position += new Vector3(0.0f, yMovement, 0.0f);
            playerMoving = true;
        }
        else if (Input.GetKey(KeyCode.S) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false) 
        {
            transform.position += new Vector3(0.0f, -yMovement, 0.0f);
            playerMoving = true;
        }

        else
        {
            playerMoving = false;
        }
        
        HandlePlayerSound();
    }

    private void HandlePlayerSound()
    {
        if (playerMoving == true)
        {
            if (!playerAudioSource.isPlaying)
            playerAudioSource.Play();
            Debug.Log("playing sound");
        }

        else
        {
            if (playerAudioSource.isPlaying)
            {
                playerAudioSource.Stop();
                Debug.Log("stopping sound");
            }
        }
    }
}
   
