using System;

// Maps each day (1-20) to the NPCs who appear in the park neighbourhood that day,
// which conversation they carry, and where they stand.
//
// Location strings must match the name of a child GameObject inside the park scene
// that serves as a spawn point (position + rotation).  e.g. create an empty called
// "Anya_Spot" and place it where Anya normally stands.
//
// Branching:
//   Day 4  Kellen  — set Day3MedicalApproved before the park scene loads.
//   Day 17-20 Anya — driven by GameManager.CurrentOutcome (AnyaOutcome enum).

public static class DayPresetLibrary
{
    // Set to false if the player rejected the medically-dependent subject on Day 3.
    public static bool Day3MedicalApproved = true;

    public static DayPreset GetPreset(int day)
    {
        AnyaOutcome outcome = GameManager.CurrentOutcome;

        return day switch
        {
            1  => Day01(),
            2  => Day02(),
            3  => Day03(),
            4  => Day04(),
            5  => Day05(),
            6  => Day06(),
            7  => Day07(),
            8  => Day08(),
            9  => Day09(),
            10 => Day10(),
            11 => Day11(),
            12 => Day12(),
            13 => Day13(),
            14 => Empty(),          // neighbourhood is empty
            15 => Day15(),
            16 => Day16(),
            17 => Day17(outcome),
            18 => Day18(outcome),
            19 => Day19(outcome),
            20 => Day20(outcome),
            _  => Empty()
        };
    }

    // ── Helpers ──────────────────────────────────────────────────────────────

    private static NpcAssignment A(string id, string loc, DialogueLine[] lines) =>
        new NpcAssignment { npcId = id, location = loc, lines = lines };

    private static DayPreset Preset(params NpcAssignment[] npcs) =>
        new DayPreset { npcs = npcs, specialEvents = Array.Empty<string>() };

    private static DayPreset Preset(string[] events, params NpcAssignment[] npcs) =>
        new DayPreset { npcs = npcs, specialEvents = events };

    private static DayPreset Empty() =>
        new DayPreset { npcs = Array.Empty<NpcAssignment>(), specialEvents = Array.Empty<string>() };

    // ── Day definitions ──────────────────────────────────────────────────────

    static DayPreset Day01() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day1_Anya),
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day1_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day1_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day1_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day1_MX2)
    );

    static DayPreset Day02() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day2_Anya),
        A("Mara",   "Mara_Spot",   DialogueLibrary.Day2_Mara),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day2_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day2_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day2_MX2)
    );

    static DayPreset Day03() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day3_Anya),
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day3_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day3_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day3_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day3_MX2)
    );

    static DayPreset Day04() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day4_Anya),
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day4_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day4_Edith),
        A("Kellen", "Kellen_Spot", Day3MedicalApproved
            ? DialogueLibrary.Day4_Kellen_Helped
            : DialogueLibrary.Day4_Kellen_Refused),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day4_MX2)
    );

    static DayPreset Day05() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day5_Anya),
        A("Mara",   "Mara_Spot",   DialogueLibrary.Day5_Mara),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day5_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day5_MX2)
        // Edith does not want to speak today
    );

    static DayPreset Day06() => Preset(
        // Anya has disappeared
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day6_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day6_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day6_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day6_MX2)
    );

    static DayPreset Day07() => Preset(
        // Anya has disappeared
        A("Mara",   "Mara_Spot",   DialogueLibrary.Day7_Mara),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day7_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day7_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day7_MX2)
    );

    static DayPreset Day08() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day8_Anya),
        A("Mara",   "Mara_Spot",   DialogueLibrary.Day8_Mara),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day8_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day8_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day8_MX2)
    );

    static DayPreset Day09() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day9_Anya),
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day9_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day9_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day9_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day9_MX2)
    );

    static DayPreset Day10() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day10_Anya),
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day10_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day10_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day10_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day10_MX2)
    );

    static DayPreset Day11() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day11_Anya),
        A("Mara",   "Mara_Spot",   DialogueLibrary.Day11_Mara),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day11_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day11_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day11_MX2)
    );

    static DayPreset Day12() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day12_Anya),
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day12_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day12_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day12_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day12_MX2)
    );

    static DayPreset Day13() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day13_Anya),
        A("Mara",   "Mara_Spot",   DialogueLibrary.Day13_Mara),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day13_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day13_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day13_MX2)
    );

    // Day 14: empty — no arrays

    static DayPreset Day15() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day15_Anya),
        A("Elias",  "Elias_Spot",  DialogueLibrary.Day15_Elias),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day15_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day15_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day15_MX2)
    );

    static DayPreset Day16() => Preset(
        A("Anya",   "Anya_Spot",   DialogueLibrary.Day16_Anya),
        A("Mara",   "Mara_Spot",   DialogueLibrary.Day16_Mara),
        A("Edith",  "Edith_Spot",  DialogueLibrary.Day16_Edith),
        A("Kellen", "Kellen_Spot", DialogueLibrary.Day16_Kellen),
        A("MX-2",   "MX2_Spot",   DialogueLibrary.Day16_MX2)
    );

    static DayPreset Day17(AnyaOutcome outcome)
    {
        var anyaLines = outcome switch
        {
            AnyaOutcome.Helped   => DialogueLibrary.Day17_Anya_Helped,
            AnyaOutcome.Refused  => DialogueLibrary.Day17_Anya_Refused,
            AnyaOutcome.SentHome => DialogueLibrary.Day17_Anya_SentHome,
            AnyaOutcome.Reported => DialogueLibrary.Day17_Anya_Reported,
            _                    => DialogueLibrary.Day17_Anya_Helped,
        };
        return Preset(
            A("Anya",   "Anya_Spot",   anyaLines),
            A("Elias",  "Elias_Spot",  DialogueLibrary.Day17_Elias),
            A("Edith",  "Edith_Spot",  DialogueLibrary.Day17_Edith),
            A("Kellen", "Kellen_Spot", DialogueLibrary.Day17_Kellen),
            A("MX-2",   "MX2_Spot",   DialogueLibrary.Day17_MX2)
        );
    }

    static DayPreset Day18(AnyaOutcome outcome)
    {
        var anyaLines = outcome switch
        {
            AnyaOutcome.Helped   => DialogueLibrary.Day18_Anya_Helped,
            AnyaOutcome.Refused  => DialogueLibrary.Day18_Anya_Refused,
            AnyaOutcome.SentHome => DialogueLibrary.Day18_Anya_SentHome,
            AnyaOutcome.Reported => DialogueLibrary.Day18_Anya_Reported,
            _                    => DialogueLibrary.Day18_Anya_Helped,
        };
        return Preset(
            A("Anya",   "Anya_Spot",   anyaLines),
            A("Mara",   "Mara_Spot",   DialogueLibrary.Day18_Mara),
            A("Edith",  "Edith_Spot",  DialogueLibrary.Day18_Edith),
            A("Kellen", "Kellen_Spot", DialogueLibrary.Day18_Kellen),
            A("MX-2",   "MX2_Spot",   DialogueLibrary.Day18_MX2)
        );
    }

    static DayPreset Day19(AnyaOutcome outcome)
    {
        // Reported = Anya does not appear on Day 19
        if (outcome == AnyaOutcome.Reported)
            return Preset(
                A("Elias",  "Elias_Spot",  DialogueLibrary.Day19_Elias),
                A("Edith",  "Edith_Spot",  DialogueLibrary.Day19_Edith),
                A("Kellen", "Kellen_Spot", DialogueLibrary.Day19_Kellen),
                A("MX-2",   "MX2_Spot",   DialogueLibrary.Day19_MX2)
            );

        var anyaLines = outcome switch
        {
            AnyaOutcome.Helped   => DialogueLibrary.Day19_Anya_Helped,
            AnyaOutcome.Refused  => DialogueLibrary.Day19_Anya_Refused,
            AnyaOutcome.SentHome => DialogueLibrary.Day19_Anya_SentHome,
            _                    => DialogueLibrary.Day19_Anya_Helped,
        };
        return Preset(
            A("Anya",   "Anya_Spot",   anyaLines),
            A("Elias",  "Elias_Spot",  DialogueLibrary.Day19_Elias),
            A("Edith",  "Edith_Spot",  DialogueLibrary.Day19_Edith),
            A("Kellen", "Kellen_Spot", DialogueLibrary.Day19_Kellen),
            A("MX-2",   "MX2_Spot",   DialogueLibrary.Day19_MX2)
        );
    }

    static DayPreset Day20(AnyaOutcome outcome)
    {
        // Refused and Reported = Anya sends no message on Day 20
        bool anyaPresent = outcome == AnyaOutcome.Helped || outcome == AnyaOutcome.SentHome;
        var anyaLines = outcome == AnyaOutcome.Helped
            ? DialogueLibrary.Day20_Anya_Helped
            : DialogueLibrary.Day20_Anya_SentHome;

        // Day 20 has both Mara AND Elias (farewell day)
        var npcs = new System.Collections.Generic.List<NpcAssignment>
        {
            A("Mara",   "Mara_Spot",   DialogueLibrary.Day20_Mara),
            A("Elias",  "Elias_Spot",  DialogueLibrary.Day20_Elias),
            A("Edith",  "Edith_Spot",  DialogueLibrary.Day20_Edith),
            A("Kellen", "Kellen_Spot", DialogueLibrary.Day20_Kellen),
            A("MX-2",   "MX2_Spot",   DialogueLibrary.Day20_MX2),
        };
        if (anyaPresent)
            npcs.Insert(0, A("Anya", "Anya_Spot", anyaLines));

        return new DayPreset { npcs = npcs.ToArray(), specialEvents = Array.Empty<string>() };
    }
}
