using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    //current text being printed and displayed
    private string currentText;
    private int currentCharacter, delayCount;
    public Sprite currentLetter;

    //text fields on the UI, for the actual reading
    public TextMeshProUGUI nameText, dialogueText;

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
        currentCharacter = delayCount = 0;
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
            if (currentCharacter < currentText.Length)
            {
                delayCount++;
                if (delayCount % 2 == 0)
                {
                    currentCharacter++;
                    string letter = currentText.Substring(currentCharacter-1, 1);
                    if(letter.Equals("<"))
                    {
                        while(!letter.Equals(">"))
                        {
                            currentCharacter++;
                            letter = currentText.Substring(currentCharacter-1, 1);
                        }
                    }
                    dialogueText.text = currentText.Substring(0, currentCharacter);
                }
            }
        }
    }
}
