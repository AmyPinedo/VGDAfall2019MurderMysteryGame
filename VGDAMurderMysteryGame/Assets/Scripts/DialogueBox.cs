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
    public GameObject dialogueMenu;

    // Start is called before the first frame update
    void Start()
    {
        dialogueCurrent = new Queue<string>();
    }


    public void startDialogue(Dialogue d)
    {

        dialogueMenu.GetComponent<menuBehavior>().openMenu();


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
        dialogueMenu.GetComponent<menuBehavior>().closeMenu();
        Debug.Log("Dialogue interaction ended");
    }
}
