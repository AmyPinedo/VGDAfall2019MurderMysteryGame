using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuBehavior : MonoBehaviour
{
    public bool isOpen = false;
    private GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void closeMenu()
    {
        if (player.GetComponent<PlayerMovement>().menuOpen == true)
        {
            Debug.Log("Menu closed: " + gameObject.name + " at position (" + transform.position.x + ", " + transform.position.y + ")");
            gameObject.GetComponent<Animator>().Play("dialogueExit");
            player.GetComponent<PlayerMovement>().menuOpen = false;
        }

    }

    public void openMenu()
    {
        if (player.GetComponent<PlayerMovement>().menuOpen == false)
        {
            Debug.Log("Menu opened: " + gameObject.name + " at position (" + transform.position.x + ", " + transform.position.y + ")");
            gameObject.GetComponent<Animator>().Play("dialogueEnter");
            player.GetComponent<PlayerMovement>().menuOpen = true;
            gameObject.SetActive(true);
        }
    }

    public void openInventory()
    {
        if (player.GetComponent<PlayerMovement>().menuOpen == false)
        {
            Debug.Log("Inventory open: " + gameObject.name);
            gameObject.GetComponent<Animator>().Play("inventoryExit");
            player.GetComponent<PlayerMovement>().menuOpen = true;
        }
    }

    public void closeInventory()
    {
        if (player.GetComponent<PlayerMovement>().menuOpen == true)
        {
            Debug.Log("Inventory closed: " + gameObject.name);
            gameObject.GetComponent<Animator>().Play("inventoryExit");
            player.GetComponent<PlayerMovement>().menuOpen = false;
        }
    }

    public void openPause()
    {
        if (player.GetComponent<PlayerMovement>().menuOpen == false)
        {
            Debug.Log("Pause opened: " + gameObject.name);
            gameObject.GetComponent<Animator>().Play("pauseEnter");
            player.GetComponent<PlayerMovement>().menuOpen = true;
        }
    }

    public void closePause()
    {
        if (player.GetComponent<PlayerMovement>().menuOpen == true)
        {
            Debug.Log("Pause closed: " + gameObject.name);
            gameObject.GetComponent<Animator>().Play("pauseExit");
            player.GetComponent<PlayerMovement>().menuOpen = false;
        }
    }

    public void returnMain()
    {
        sceneChanger.changeScene("MainMenu");
    }
}
