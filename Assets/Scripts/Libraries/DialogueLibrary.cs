public static class DialogueLibrary
{
    // ── Shared name pool ─────────────────────────────────────────────────────
    // All subjects draw from the same human-sounding pool.
    // Names are not a reliable tell — look at the document fields instead.

    public static readonly string[] Names = new string[]
    {
        "Maris Venn",
        "Sorin Dalca",
        "Yeva Pratt",
        "Lena Kraus",
        "Oren Falk",
        "Dasha Merel",
        "Tomasz Brin",
        "Anya Vosk",
        "Sable Minn",
        "Calder Roe",
        "Fen Adler",
        "Reva Sorn",
        "Ilya Dunn",
        "Petra Hask",
        "Zolan Reik",
        "Corra Meld",
        "Udo Prenn",
        "Tasha Weil",
        "Nico Brant",
        "Sera Lund"
    };

    // ── Purpose of visit dialogue ────────────────────────────────────────────
    // Humans tend to be personal and specific; robots tend to be brief and task-oriented.
    // A disguised robot still draws from RobotPurpose — a subtle tell.

    public static readonly string[] HumanPurpose = new string[]
    {
        "I am traveling.",
        "To get new implants.",
        "I work here. Daily commute.",
        "Sightseeing, nothing more.",
        "Visiting family on the other side.",
        "Medical appointment.",
        "Business meeting. I have my papers.",
        "I am a student here for the semester.",
        "Just passing through.",
        "Holiday. My first time crossing."
    };

    public static readonly string[] RobotPurpose = new string[]
    {
        "Delivering the package.",
        "Parts replacement. Scheduled.",
        "Patrol duty. Authorization on file.",
        "Maintenance cycle.",
        "Cargo transport. Route 7.",
        "System update required at the facility.",
        "Fulfilling logistics order.",
        "Recharging at the depot.",
        "Following programmed route.",
        "Waste processing assignment."
    };
}
