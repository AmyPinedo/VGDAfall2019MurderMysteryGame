using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteractable : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogueMenu;
    public void startDialogue()
    {
        dialogueMenu.GetComponent<DialogueBox>().startDialogue(dialogue);
    }

    private void OnMouseDown()
    {

        startDialogue();
    }
}
