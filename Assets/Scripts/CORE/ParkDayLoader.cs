using UnityEngine;

// Place on a GameObject in 03_ParkNeighbourhood.
// On Start it reads the current day, picks the right DayPreset, and activates/positions
// every stationary NPC that should appear today.
public class ParkDayLoader : MonoBehaviour
{
    private void Start()
    {
        int day = GameManager.Days;
        DayPreset preset = DayPresetLibrary.GetPreset(day);

        // Gather every NPCInteractable in the scene, including inactive ones.
        NPCInteractable[] allNpcs = FindObjectsByType<NPCInteractable>(
            FindObjectsInactive.Include, FindObjectsSortMode.None);

        // Hide every park NPC (identified by having an npcId set).
        foreach (NPCInteractable npc in allNpcs)
        {
            if (!string.IsNullOrEmpty(npc.npcId))
                npc.gameObject.SetActive(false);
        }

        // Activate and configure only those present today.
        foreach (NpcAssignment assignment in preset.npcs)
        {
            NPCInteractable match = System.Array.Find(allNpcs, n => n.npcId == assignment.npcId);
            if (match == null) continue;

            // Move to today's spawn point if one is named.
            if (!string.IsNullOrEmpty(assignment.location))
            {
                GameObject spot = GameObject.Find(assignment.location);
                if (spot != null)
                {
                    match.transform.position = spot.transform.position;
                    match.transform.rotation = spot.transform.rotation;
                }
            }

            match.SetLines(assignment.lines);
            match.gameObject.SetActive(true);
        }
    }
}
