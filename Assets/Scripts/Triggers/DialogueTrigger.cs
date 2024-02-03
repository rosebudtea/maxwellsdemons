using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public NewDialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
