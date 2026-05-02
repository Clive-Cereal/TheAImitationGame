using System;

[Serializable]
public struct NpcAssignment
{
    public string npcId;
    public string location;     // name of a spawn-point GameObject in the park scene
    public DialogueLine[] lines;
}

[Serializable]
public struct DayPreset
{
    public NpcAssignment[] npcs;
    public string[] specialEvents;  // named keys other systems can check
}
