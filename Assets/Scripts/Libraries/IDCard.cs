using UnityEngine;
using System.Collections.Generic;

public class IDCard : MonoBehaviour
{
    // Core identity fields
    public bool _isRobot;
    public string _dateofbirth;   // formatted "DD MMM YYYY"
    public string idNumber;       // 8-digit string e.g. "09246194"
    public Nationality _nationality;

    // Expiry
    public bool isExpired;
    public int expiryYear;

    // Declarations
    public List<DeclarationItem> _declaration = null;
    public MedicationProduct medicationDetail;      // populated when Medication is declared
    public SpecialSubstanceProduct substanceDetail; // populated when SpecialSubstance is declared

    // Cyberware registry lives on Certificate (ARC), not the ID card
}
