using UnityEngine;
using System.Collections.Generic;

public class Document : MonoBehaviour
{
    // Core identity fields
    public bool _isRobot;
    public int _dateofbirth;
    public Nationality _nationality;

    // Expiry
    public bool isExpired;
    public int expiryYear;

    // Declarations
    public List<DeclarationItem> _declaration = null;
    public MedicationProduct medicationDetail;      // populated when Medication is declared
    public SpecialSubstanceProduct substanceDetail; // populated when SpecialSubstance is declared

    // Cyberware registry
    public List<Cyberware> cyberware = null;
}
