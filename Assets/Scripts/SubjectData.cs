using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SubjectData", menuName = "TheAImitationGame/SubjectData")]
public class SubjectData : ScriptableObject
{
    [Header("Identity")]
    public string displayName;
    public bool isRobot;

    [Header("Document Fields")]
    public int dateofbirth;
    public Nationality nationality;
    public DeclarationItem[] declarations;

    [Header("Dialogue")]
    [TextArea(2, 4)]
    public string purposeDialogue;

    [Header("Physical")]
    public float weight;
    public float height;
}
