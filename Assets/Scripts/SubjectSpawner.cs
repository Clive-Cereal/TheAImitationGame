using UnityEngine;
using System.Collections.Generic;

public class SubjectSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject subjectPrefab;
    [SerializeField] private Transform spawnPoint;

    [Header("Subject Pool")]
    [SerializeField] private SubjectData[] subjectPool;

    private GameObject currentSubjectInstance;

    public Subject SpawnSubject()
    {
        if (subjectPool == null || subjectPool.Length == 0)
        {
            Debug.LogWarning("SubjectSpawner: subjectPool is empty.");
            return null;
        }

        DestroyCurrentSubject();

        SubjectData data = subjectPool[Random.Range(0, subjectPool.Length)];
        currentSubjectInstance = Instantiate(subjectPrefab, spawnPoint.position, spawnPoint.rotation);

        Subject subject   = currentSubjectInstance.GetComponent<Subject>();
        Document document = currentSubjectInstance.GetComponent<Document>();

        subject.isRobot         = data.isRobot;
        subject.displayName     = data.displayName;
        subject.dateofbirth     = data.dateofbirth;
        subject.nationality     = data.nationality;
        subject.weight          = data.weight;
        subject.height          = data.height;
        subject.purposeDialogue = data.purposeDialogue;

        document._isRobot     = data.isRobot;
        document._dateofbirth = data.dateofbirth;
        document._nationality = data.nationality;
        document._declaration = new List<DeclarationItem>(data.declarations);

        subject.document = document;
        return subject;
    }

    public void DestroyCurrentSubject()
    {
        if (currentSubjectInstance != null)
        {
            Destroy(currentSubjectInstance);
            currentSubjectInstance = null;
        }
    }
}
