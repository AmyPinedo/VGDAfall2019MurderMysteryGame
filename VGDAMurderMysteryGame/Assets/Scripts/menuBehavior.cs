using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuBehavior : MonoBehaviour
{
    public bool isOpen = false;

    public void setMenu(bool b)
    {
        isOpen = b;
    }

    public void closeMenu()
    {
        Debug.Log("Menu closed: " + gameObject.name + " at position (" + transform.position.x + ", " + transform.position.y + ")");
        gameObject.GetComponent<Animator>().Play("dialogueExit");
        isOpen = false;

    }

    public void openMenu()
    {
        Debug.Log("Menu opened: " + gameObject.name + " at position (" + transform.position.x + ", " + transform.position.y + ")");
        gameObject.GetComponent<Animator>().Play("dialogueEnter");
        gameObject.SetActive(true);
        isOpen = true;
    }

    public void openInventory()
    {
        Debug.Log("Inventory open: " + gameObject.name);
        gameObject.GetComponent<Animator>().Play("inventoryExit");
        isOpen = false;
    }

    public void closeInventory()
    {
        Debug.Log("Inventory closed: " + gameObject.name);
        gameObject.GetComponent<Animator>().Play("inventoryExit");
        isOpen = false;
    }
}
