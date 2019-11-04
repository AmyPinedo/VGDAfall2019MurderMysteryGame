using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueBox : MonoBehaviour
{
    public static Queue<string> dialogueCurrent;
    public TMP_Text dialogueName;
    public TMP_Text dialogueText;
    public Button dialogueNextButton;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        dialogueCurrent = new Queue<string>();
        dialogueName.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(false);
        dialogueNextButton.gameObject.SetActive(false);
    }


    public void startDialogue(Dialogue d)
    {

        animator.SetBool("isOpen", true);
        dialogueName.gameObject.SetActive(true);
        dialogueText.gameObject.SetActive(true);
        dialogueNextButton.gameObject.SetActive(true);


        Debug.Log("Starting dialogue interaction with " + d.name);
        dialogueName.text = d.name;
        dialogueCurrent.Clear();
        
        foreach (string sentence in d.sentences)
        {
            dialogueCurrent.Enqueue(sentence);
        }
        displayNextSentence();
    }
    public void displayNextSentence()
    {
        if (dialogueCurrent.Count == 0)
        {
            endDialogue();
            return;
        }
        string sentence = dialogueCurrent.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }
    public void endDialogue()
    {
        dialogueName.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(false);
        dialogueNextButton.gameObject.SetActive(false);
        animator.SetBool("isOpen", false);
        Debug.Log("Dialogue interaction ended");
    }
}
