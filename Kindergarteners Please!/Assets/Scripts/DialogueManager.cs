using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private string currentText;
    private int printedCharacters, delayCount;
    public Text nameText, dialogueText;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("starting converations with " + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count==0)
        {
            EndDialogue();
            return;
        }
        printedCharacters = delayCount = 0;
        currentText = sentences.Dequeue();
        Debug.Log(currentText);
        
    }

    void EndDialogue()
    {
        Debug.Log("no more dialogue");
        currentText = null;
        nameText.text = dialogueText.text = "";
    }

    void Update()
    {
        if (currentText != null)
        {
            if (printedCharacters < currentText.Length)
            {
                delayCount++;
                if (delayCount % 2 == 0)
                {
                    printedCharacters++;
                    dialogueText.text = currentText.Substring(0, printedCharacters);
                }
            }
        }
    }
}
