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
    Paused
}

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
