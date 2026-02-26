using UnityEngine;

public class Subject : MonoBehaviour
{
    public bool isRobot;
    public int dateofbirth;
    public Nationality nationality;
    public float weight;
    public float height;
    public float bionicPercent;
    public float metalPercent;

    public Document document;

    public string displayName;
    public string purposeDialogue;

    public SubjectType subjectType;
    public InvalidCause invalidCause;
}
