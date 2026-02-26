using System;

[Serializable]
public class Cyberware
{
    public string implantID;
    public int installYear;
    public CyberwareType type;
    public CyberwareManufacturer manufacturer;
    public string purpose;
    public bool isApproved;
}
