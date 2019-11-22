using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteractable : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogueMenu;
    public GameObject dialogueMenuSprite;
    public Sprite dialogueImage;

    private Color basicColor = Color.white;
    private Color hoverColor = Color.gray;
    private SpriteRenderer renderer;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void startDialogue()
    {
        if (player.GetComponent<PlayerMovement>().menuOpen == false)
        {
            dialogueMenuSprite.GetComponent<SpriteRenderer>().sprite = dialogueImage;
            dialogueMenu.GetComponent<DialogueBox>().startDialogue(dialogue);
        }
    }

    private void OnMouseDown()
    {
        if (player.GetComponent<playerInventory>().playerInventoryVar.Count < 4)
        {
            startDialogue();
        }
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = hoverColor;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = basicColor;
    }
}
