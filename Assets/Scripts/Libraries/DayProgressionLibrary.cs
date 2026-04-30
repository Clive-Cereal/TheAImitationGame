using UnityEngine;

public struct DayRules
{
    public InvalidCause[] allowedCauses;
    public bool           logHistoryUnlocked;
    public string         bulletinMessage;
    public string         supervisorMessage;
}

// Story-accurate per-day rule progression based on the narrative document.
// Acts:
//   Act 1 (Days  1– 8): Normalisation   — teach mechanics, subtle cracks
//   Act 2 (Days  9–18): Pattern Recognition — HC becomes visible, Anya deepens
//   Act 3 (Days 19–20): System Awareness / Final Attempt — all rules active
public static class DayProgressionLibrary
{
    private static readonly InvalidCause[] DocsOnly = new[]
    {
        InvalidCause.DocumentMismatch,
        InvalidCause.ExpiredDocument
    };

    private static readonly InvalidCause[] DocsAndContraband = new[]
    {
        InvalidCause.DocumentMismatch,
        InvalidCause.ExpiredDocument,
        InvalidCause.ProhibitedItem
    };

    private static readonly InvalidCause[] All = new[]
    {
        InvalidCause.DocumentMismatch,
        InvalidCause.ExpiredDocument,
        InvalidCause.ProhibitedItem,
        InvalidCause.DisapprovedCyberware
    };

    // Index 0 = Day 1.
    private static readonly DayRules[] Rules = new DayRules[]
    {
        // ── Act 1: Normalisation ────────────────────────────────────────────────

        // Day 1 — Orientation: simple document and legality checks only.
        new DayRules { allowedCauses = DocsOnly },

        // Day 2 — Orientation continued.
        new DayRules { allowedCauses = DocsOnly },

        // Day 3 — First Moral Test: unlicensed work augments and out-of-date
        //          medical implants now possible.
        new DayRules { allowedCauses = DocsAndContraband },

        // Day 4 — First Moral Test continued.
        new DayRules { allowedCauses = DocsAndContraband }, 

        // Day 5 — The Incident: entrant with HC-certified firmware cleared cleanly;
        //          DisapprovedCyberware not yet in play (HC is still trusted).
        new DayRules { allowedCauses = DocsAndContraband },

        // Day 6 — The Crack: bulletin reports augment instability; supervisor
        //          pushes HC firmware compliance check overnight; log history unlocked.
        new DayRules
        {
            allowedCauses       = All,
            logHistoryUnlocked  = true,
            bulletinMessage     = "Augment Instability Leaves 3 Injured",
            supervisorMessage   = "Double-check HC firmware compliance. New verification tool now available."
        },

        // Day 7 — The Crack continued: firmware patch pattern discoverable in logs.
        new DayRules
        {
            allowedCauses       = All,
            logHistoryUnlocked  = true,
            bulletinMessage     = "Augment Instability Leaves 3 Injured",
            supervisorMessage   = "Ensure all HC firmware holders are compliant before clearance."
        },

        // Day 8 — First Absence: Anya missing; all checks active.
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // ── Act 2: Pattern Recognition ──────────────────────────────────────────

        // Day 9 — She Returns: second instability case; same HC firmware pattern.
        new DayRules
        {
            allowedCauses     = All,
            logHistoryUnlocked = true,
            supervisorMessage = "Second augment instability report filed. Review firmware logs."
        },

        // Day 10
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 11
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 12 — Anya reveals childhood implant details; Elias faces mandatory augment.
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 13 — Document workaround thread begins (Kellen).
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 14 — Empty neighbourhood day; border operates as normal.
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 15
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 16 — Elias post-augment; Mara questions the system.
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // ── Act 3+4: System Awareness / Final Attempt ───────────────────────────

        // Day 17 — Player makes their Anya decision.
        new DayRules
        {
            allowedCauses     = All,
            logHistoryUnlocked = true,
            supervisorMessage = "Capacity limits tightening. Automated risk scoring now active."
        },

        // Day 18
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 19 — Anya's crossing attempt.
        new DayRules { allowedCauses = All, logHistoryUnlocked = true },

        // Day 20 — Final day.
        new DayRules
        {
            allowedCauses     = All,
            logHistoryUnlocked = true,
            bulletinMessage   = "System-wide HC compliance audit announced.",
            supervisorMessage = "All officers on full alert. No exceptions today."
        },
    };

    public static DayRules GetRules(int day)
    {
        int index = Mathf.Clamp(day - 1, 0, Rules.Length - 1);
        return Rules[index];
    }

    public static bool IsLogHistoryUnlocked => GetRules(GameManager.Days).logHistoryUnlocked;
}
