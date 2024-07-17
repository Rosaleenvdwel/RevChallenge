using UnityEngine;
using UnityEngine.UI;

public class NPCdialogue : MonoBehaviour
{
    public GameObject dialogueUI;
    public Text dialogueText;
    
    public void ShowDialogue(string dialogue)
    {
        dialogueUI.SetActive(true);
        dialogueText.text = dialogue;
    }
    
    public void HideDialogue()
    {
        dialogueUI.SetActive(false);
    }
}

