using System;

[Serializable]
public struct MedicationProduct
{
    public string name;
    public MedicationType type;
    public CyberwareManufacturer manufacturer;
}

[Serializable]
public struct SpecialSubstanceProduct
{
    public string name;
    public SpecialSubstanceType type;
    public CyberwareManufacturer manufacturer;
}

public static class ItemLibrary
{
    public static readonly MedicationProduct[] Medications = new MedicationProduct[]
    {
        // Neurosuppressant
        new MedicationProduct { name = "Calmax-5",      type = MedicationType.Neurosuppressant,    manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new MedicationProduct { name = "DampenEase",    type = MedicationType.Neurosuppressant,    manufacturer = CyberwareManufacturer.HorcrowCorporation  },
        new MedicationProduct { name = "NeuroQuell",    type = MedicationType.Neurosuppressant,    manufacturer = CyberwareManufacturer.BioForge             },

        // Cognitive Stimulant
        new MedicationProduct { name = "FocusDrive",    type = MedicationType.CognitiveStimulant,  manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new MedicationProduct { name = "ClearMind XR",  type = MedicationType.CognitiveStimulant,  manufacturer = CyberwareManufacturer.NeuroplexSystems     },
        new MedicationProduct { name = "SharpEdge",     type = MedicationType.CognitiveStimulant,  manufacturer = CyberwareManufacturer.AxiomCorp            },

        // Painkiller
        new MedicationProduct { name = "Dulcipan",      type = MedicationType.Painkiller,          manufacturer = CyberwareManufacturer.AxiomCorp            },
        new MedicationProduct { name = "NumbaBlok",     type = MedicationType.Painkiller,          manufacturer = CyberwareManufacturer.HorcrowCorporation  },
        new MedicationProduct { name = "SynaRelief",    type = MedicationType.Painkiller,          manufacturer = CyberwareManufacturer.SynapetchIndustries },

        // Antibiotic
        new MedicationProduct { name = "OrbiCillin",    type = MedicationType.Antibiotic,          manufacturer = CyberwareManufacturer.BioForge             },
        new MedicationProduct { name = "SynBact-7",     type = MedicationType.Antibiotic,          manufacturer = CyberwareManufacturer.NeuroplexSystems     },
        new MedicationProduct { name = "PurgePlex",     type = MedicationType.Antibiotic,          manufacturer = CyberwareManufacturer.AxiomCorp            },

        // Immuno Booster
        new MedicationProduct { name = "VitalShield",   type = MedicationType.ImmunoBooster,       manufacturer = CyberwareManufacturer.BioForge             },
        new MedicationProduct { name = "ImmunePlex",    type = MedicationType.ImmunoBooster,       manufacturer = CyberwareManufacturer.AxiomCorp            },
        new MedicationProduct { name = "DefendaCore",   type = MedicationType.ImmunoBooster,       manufacturer = CyberwareManufacturer.HorcrowCorporation  },

        // Synth Blood
        new MedicationProduct { name = "HemoCraft",     type = MedicationType.SynthBlood,          manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new MedicationProduct { name = "FlowTech-A",    type = MedicationType.SynthBlood,          manufacturer = CyberwareManufacturer.HorcrowCorporation  },

        // Hormone Regulator
        new MedicationProduct { name = "BalancEx",      type = MedicationType.HormoneRegulator,    manufacturer = CyberwareManufacturer.NeuroplexSystems     },
        new MedicationProduct { name = "SteadyFlow",    type = MedicationType.HormoneRegulator,    manufacturer = CyberwareManufacturer.BioForge             },

        // Anti-Rejection
        new MedicationProduct { name = "AcceptaMax",    type = MedicationType.AntiRejection,       manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new MedicationProduct { name = "BondWell",      type = MedicationType.AntiRejection,       manufacturer = CyberwareManufacturer.NeuroplexSystems     },

        // Sedative
        new MedicationProduct { name = "SlumbaTide",    type = MedicationType.Sedative,            manufacturer = CyberwareManufacturer.HorcrowCorporation  },
        new MedicationProduct { name = "CalmDrift",     type = MedicationType.Sedative,            manufacturer = CyberwareManufacturer.BioForge             },
        new MedicationProduct { name = "NightEase",     type = MedicationType.Sedative,            manufacturer = CyberwareManufacturer.AxiomCorp            },

        // Nano Repair
        new MedicationProduct { name = "NanoFix Pro",   type = MedicationType.NanoRepair,          manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new MedicationProduct { name = "TinyMend",      type = MedicationType.NanoRepair,          manufacturer = CyberwareManufacturer.AxiomCorp            },
    };

    public static readonly SpecialSubstanceProduct[] SpecialSubstances = new SpecialSubstanceProduct[]
    {
        // Industrial Solvent
        new SpecialSubstanceProduct { name = "DissolvX",      type = SpecialSubstanceType.IndustrialSolvent,   manufacturer = CyberwareManufacturer.AxiomCorp            },
        new SpecialSubstanceProduct { name = "ThermoBreak",   type = SpecialSubstanceType.IndustrialSolvent,   manufacturer = CyberwareManufacturer.HorcrowCorporation  },
        new SpecialSubstanceProduct { name = "CoreFuse",      type = SpecialSubstanceType.IndustrialSolvent,   manufacturer = CyberwareManufacturer.NeuroplexSystems     },

        // Synthetic Narcotic
        new SpecialSubstanceProduct { name = "BlissDust",     type = SpecialSubstanceType.SyntheticNarcotic,   manufacturer = CyberwareManufacturer.NeuroplexSystems     },
        new SpecialSubstanceProduct { name = "NovaDream",     type = SpecialSubstanceType.SyntheticNarcotic,   manufacturer = CyberwareManufacturer.HorcrowCorporation  },

        // Bio Activator
        new SpecialSubstanceProduct { name = "CellSurge",     type = SpecialSubstanceType.BioActivator,        manufacturer = CyberwareManufacturer.BioForge             },
        new SpecialSubstanceProduct { name = "GrowthPlex",    type = SpecialSubstanceType.BioActivator,        manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new SpecialSubstanceProduct { name = "ProlifaGen",    type = SpecialSubstanceType.BioActivator,        manufacturer = CyberwareManufacturer.NeuroplexSystems     },

        // Radioactive Material
        new SpecialSubstanceProduct { name = "IsoVial-9",     type = SpecialSubstanceType.RadioactiveMaterial, manufacturer = CyberwareManufacturer.AxiomCorp            },
        new SpecialSubstanceProduct { name = "DecayPack",     type = SpecialSubstanceType.RadioactiveMaterial, manufacturer = CyberwareManufacturer.HorcrowCorporation  },

        // Neural Fluid
        new SpecialSubstanceProduct { name = "SynaBase",      type = SpecialSubstanceType.NeuralFluid,         manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new SpecialSubstanceProduct { name = "ConductaFluid", type = SpecialSubstanceType.NeuralFluid,         manufacturer = CyberwareManufacturer.NeuroplexSystems     },

        // Combustible Compound
        new SpecialSubstanceProduct { name = "IgniPaste",     type = SpecialSubstanceType.CombustibleCompound, manufacturer = CyberwareManufacturer.AxiomCorp            },
        new SpecialSubstanceProduct { name = "FlareGel-X",    type = SpecialSubstanceType.CombustibleCompound, manufacturer = CyberwareManufacturer.HorcrowCorporation  },

        // Corrosive Agent
        new SpecialSubstanceProduct { name = "ErodeChem",     type = SpecialSubstanceType.CorrosiveAgent,      manufacturer = CyberwareManufacturer.AxiomCorp            },
        new SpecialSubstanceProduct { name = "AcidPrime",     type = SpecialSubstanceType.CorrosiveAgent,      manufacturer = CyberwareManufacturer.BioForge             },

        // Experimental Serum
        new SpecialSubstanceProduct { name = "SerumX-01",     type = SpecialSubstanceType.ExperimentalSerum,   manufacturer = CyberwareManufacturer.SynapetchIndustries },
        new SpecialSubstanceProduct { name = "TrialVial",     type = SpecialSubstanceType.ExperimentalSerum,   manufacturer = CyberwareManufacturer.BioForge             },
    };

    // Cyberware purposes — displayed on the document
    public static readonly string[] CyberwarePurposes = new string[]
    {
        "Medical necessity",
        "Military service",
        "Labour enhancement",
        "Sensory repair",
        "Life support",
        "Occupational requirement",
        "Neurological therapy",
        "Prosthetic replacement"
    };
}
