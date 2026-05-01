using System;
using UnityEngine;

[Serializable]
public struct DialogueLine
{
    public string speaker;
    [TextArea(1, 3)]
    public string text;

    public DialogueLine(string speaker, string text)
    {
        this.speaker = speaker;
        this.text    = text;
    }
}
