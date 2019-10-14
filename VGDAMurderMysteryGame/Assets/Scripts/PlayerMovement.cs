using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xMovement = 0.0f;
    public float yMovement = 0.0f;
    void Start()
    {
        xMovement = 0.0f;
        yMovement = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        ///Constantly check for movement
        transform.position += new Vector3(xMovement, yMovement, 0);

        ///Horizontal movement
        if (Input.GetKey(KeyCode.A))
        {
            xMovement = -0.2f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            xMovement = 0.2f;
        }
        else
        {
            xMovement = 0.0f;
        }

        ///Vertical movement
        if (Input.GetKey(KeyCode.W))
        {
            yMovement = 0.2f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            yMovement = -0.2f;
        }
        else
        {
            yMovement = 0.0f;
        }
    }
}
