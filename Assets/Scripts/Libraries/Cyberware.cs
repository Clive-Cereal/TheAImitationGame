using System;

[Serializable]
public class Cyberware
{
    public string implantID;
    public string installDate;    // formatted "dd/MM/yyyy"
    public CyberwareType type;
    public CyberwareManufacturer manufacturer;
    public string purpose;
    public bool isApproved;
}
