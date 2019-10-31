using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointerBehaviour : MonoBehaviour
{
    private Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        ///Pointer follows the player's mouse position
        if(globalVariables.menuOpen == false)
        {
            Vector3 a = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
            a.Set(a.x, a.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, a, 0.5f);
        }

        //print("Cursor: " + transform.position.z);

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        ///If a specific item is clicked-on, then it will be deleated and added to the player's inventory
        if (collision.gameObject.name == "testCollectable" && globalVariables.mouseDown == true)
        {
            globalVariables.playerInventory.Add(globalVariables.varInventory.items[0]);
            Destroy(collision.gameObject);
        }
       
    }
}
