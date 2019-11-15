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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///Horizontal movement
        if (Input.GetKey(KeyCode.A) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.position += new Vector3(-xMovement, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.position += new Vector3(xMovement, 0.0f, 0.0f);
        }

        ///Vertical movement
        if (Input.GetKey(KeyCode.W) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false)
        {
            transform.position += new Vector3(0.0f, yMovement, 0.0f);
        }
        else if (Input.GetKey(KeyCode.S) && menuOpen == false && dialogueBox.GetComponent<menuBehavior>().isOpen == false && inventoryOpen == false) 
        {
            transform.position += new Vector3(0.0f, -yMovement, 0.0f);

        }
    }
}
   
