using UnityEngine;
using System.Collections.Generic;

public class Certificate : MonoBehaviour
{
    public string displayName;
    public string dateOfBirth;   // "DD MMM YYYY"
    public string idNumber;
    public Nationality city;
    public List<Cyberware> cyberware = new();
}
