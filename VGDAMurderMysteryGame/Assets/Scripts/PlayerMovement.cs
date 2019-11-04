using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private float xMovement = 0.2f;
    private float yMovement = 0.2f;
    public Animator dialogueAnimator;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///Horizontal movement
        if (Input.GetKey(KeyCode.A) && globalVariables.menuOpen == false && dialogueAnimator.GetBool("isOpen") == false)
        {
            transform.position += new Vector3(-xMovement, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D) && globalVariables.menuOpen == false && dialogueAnimator.GetBool("isOpen") == false)
        {
            transform.position += new Vector3(xMovement, 0.0f, 0.0f);
        }

        ///Vertical movement
        if (Input.GetKey(KeyCode.W) && globalVariables.menuOpen == false && dialogueAnimator.GetBool("isOpen") == false)
        {
            transform.position += new Vector3(0.0f, yMovement, 0.0f);
        }
        else if (Input.GetKey(KeyCode.S) && globalVariables.menuOpen == false && dialogueAnimator.GetBool("isOpen") == false)
        {
            transform.position += new Vector3(0.0f, -yMovement, 0.0f);

        }

        ///INVENTORY MENU
        if (Input.GetKey(KeyCode.E) && globalVariables.menuOpen == false)
        {
            globalVariables.menuOpen = true;
        }
        else if (Input.GetKeyUp(KeyCode.E) && globalVariables.menuOpen == true)
        {
            globalVariables.menuOpen = false;
        }

    }
}
   
