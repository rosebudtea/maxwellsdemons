using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    private Queue<string> lines;
    private string line;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        lines = new Queue<string>();
    }

    public bool CheckTextFinished()
    {
        if (dialogueText.text == line)
        {
            return DisplayNextLine();
        }
        else
        {
            StopAllCoroutines();
            dialogueText.text = line;
            return false;
        }
    }

    public void StartDialogue(NewDialogue dialogue)
    {
        animator.SetBool("isOpen", true);

        nameText.text = dialogue.name;
        lines.Clear();

        foreach(string line in dialogue.sentences)
        {
            lines.Enqueue(line);
        }

        DisplayNextLine();
    }

    public bool DisplayNextLine()
    {
        if (lines.Count == 0)
        {
            EndDialogue();
            return true;
        }

        line = lines.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeLine(line));
        return false;
    }

    IEnumerator TypeLine(string line)
    {
        dialogueText.text = string.Empty;
        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }
}
