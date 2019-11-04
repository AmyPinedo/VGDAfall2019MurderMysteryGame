using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteractable : MonoBehaviour
{
    public Dialogue dialogue;
    public void startDialogue()
    {
        FindObjectOfType<DialogueBox>().startDialogue(dialogue);
    }

    private void OnMouseDown()
    {
        
        Debug.Log("I have been clicked");
    }
}
