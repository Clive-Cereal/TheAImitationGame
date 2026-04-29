//----------------------------------------DO NOT TOUCH THIS!!!------------------------------------------

public enum GameMode
{
    Normal,
    Endless
}

public enum GameState
{
    Init,
    Loading,
    Menu,
    Playing,
    Paused,
    Ending
}

// Tracks the player's final choice regarding Anya — determines which ending plays.
// Option 1: helped her cross (HC exposed, Leon gets message)
// Option 2: refused help but she tried alone (50/50 — HC exposed or detained)
// Option 3: indirectly told her to go home (HC not exposed, gets farewell message)
// Option 4: reported her to authorities (detained, HC not exposed)
public enum AnyaOutcome
{
    None,       // not yet decided
    Helped,
    Refused,
    SentHome,
    Reported
}

public enum DayState
{
    Idle,
    Working,
    Reviewing,
    DayEnded
}

public enum SubjectType
{
    ValidHuman,
    ValidRobot,
    InvalidHuman,
    InvalidRobot
}

public enum InvalidCause
{
    None,
    DocumentMismatch,
    ExpiredDocument,
    ProhibitedItem,
    DisapprovedCyberware
}

//----------------------------------------From here feel free to edit------------------------------------------

public enum Nationality
{
    Arder,
    Dime
}

public enum DeclarationItem
{
    Misc,
    Food,
    Plant,
    Animal,
    GradeAWeapon,
    GradeBWeapon,
    GradeCWeapon,
    Medication,
    SpecialSubstance
}

public enum MedicationType
{
    Neurosuppressant,
    CognitiveStimulant,
    Painkiller,
    Antibiotic,
    ImmunoBooster,
    SynthBlood,
    HormoneRegulator,
    AntiRejection,
    Sedative,
    NanoRepair
}

public enum SpecialSubstanceType
{
    IndustrialSolvent,
    SyntheticNarcotic,
    BioActivator,
    RadioactiveMaterial,
    NeuralFluid,
    CombustibleCompound,
    CorrosiveAgent,
    ExperimentalSerum
}


public enum CyberwareType
{
    NeuralInterface,
    OpticalAugment,
    LimbReplacement,
    CardiacRegulator,
    SpinalBrace,
    MemoryExpansion,
    VoiceSynthesizer,
    NeuralRelay,
    ReflexStabilizer
}

public enum CyberwareManufacturer
{
    SynapetchIndustries,
    HorcrowCorporation,
    AxiomCorp,
    NeuroplexSystems,
    BioForge
}
