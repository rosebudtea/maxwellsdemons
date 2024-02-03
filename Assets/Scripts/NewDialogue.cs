using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NewDialogue
{
    [TextArea(3, 10)]
    public string[] sentences;
    public string name;
}
