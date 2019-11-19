using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteractable : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogueMenu;
    public GameObject dialogueMenuSprite;
    public Sprite dialogueImage;

    public void startDialogue()
    {
        dialogueMenuSprite.GetComponent<SpriteRenderer>().sprite = dialogueImage; 
        dialogueMenu.GetComponent<DialogueBox>().startDialogue(dialogue);
    }

    private void OnMouseDown()
    {

        startDialogue();
    }
}
