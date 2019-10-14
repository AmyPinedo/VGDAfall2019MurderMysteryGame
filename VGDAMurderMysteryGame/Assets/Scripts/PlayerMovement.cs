using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public GameObject cursor;
    private bool movingX = false;
    private bool movingY = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///Constantly check for movement
        transform.position += new Vector3(globalVariables.xPlayerMovement, globalVariables.yPlayerMovement, transform.position.z);

        ///Horizontal movement
        if (Input.GetKey(KeyCode.A) && globalVariables.menuOpen == false)
        {
            globalVariables.xPlayerMovement = -0.2f;
        }
        else if (Input.GetKey(KeyCode.D) && globalVariables.menuOpen == false)
        {
            globalVariables.xPlayerMovement = 0.2f;
        }
        else
        {
            globalVariables.xPlayerMovement = 0.0f;
        }

        ///Vertical movement
        if (Input.GetKey(KeyCode.W) && globalVariables.menuOpen == false)
        {
            globalVariables.yPlayerMovement = 0.2f;
        }
        else if (Input.GetKey(KeyCode.S) && globalVariables.menuOpen == false)
        {
            globalVariables.yPlayerMovement = -0.2f;

        }
        else
        {
            globalVariables.yPlayerMovement = 0.0f;
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

        ///Change mouse variable
        if (Input.GetMouseButtonDown(0))
        {
            globalVariables.mouseDown = true;
            print("Mouse is down");
        }
        else
        {
            globalVariables.mouseDown = false;
            print("Mouse is up");
        }

        print("Player: " + transform.position.z);
    }
}
   
