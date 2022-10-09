using XRL;

using static XRL.PopulationExtensions;

// Thank Pyre for this garbage because I would've ripped mine own head off, part 2
namespace TychoMod
{
    [HasGameBasedStaticCache]
    public static class Initialiser
    {
        [GameBasedCacheInit]
        public static void Start()
        {
            // Return if our populations already exist.
            // if (PopulationManager.GetEach("WatervineCreatures", null).Contains("SecludedWitchWatervine"))
            // 	return;
            if (PopulationManager.HasTable("SecludedWitchWatervine")) return;

            // Creatures, Critters & Fauna
            Static
                .AddToPopTable("WatervineCreatures",
                new PopulationTable {
                    Name = "SecludedWitchWatervine",
                    Weight = 1
                });
            Static
                .AddToPopTable("HillCreatures",
                new PopulationTable {
                    Name = "SecludedWitchHills",
                    Weight = 1
                });
            Static
                .AddToPopTable("FlowerfieldCreatures",
                new PopulationObject {
                    Blueprint = "River Nymph",
                    Weight = 5,
                    Number = "3d3"
                });
            Static
                .AddToPopTable("Tier2CaveCreatures",
                new PopulationObject {
                    Blueprint = "River Nymph",
                    Weight = 3,
                    Number = "3d3"
                });
            Static
                .AddToPopTable("Tier2CaveCreatures",
                new PopulationObject {
                    Blueprint = "Moonkoi Fish",
                    Weight = 1,
                    Number = "1d2"
                });
            Static
                .AddToPopTable("Tier2CaveCreatures",
                new PopulationTable { Name = "FaerieGroup", Weight = 1 });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationTable { Name = "LesserChimeras", Weight = 1 });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationObject {
                    Blueprint = "Firefox",
                    Weight = 5,
                    Number = "1d2"
                });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationObject {
                    Blueprint = "Rogue Mechanite",
                    Weight = 3,
                    Number = "1d1"
                });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationObject {
                    Blueprint = "Genesplice Worm",
                    Weight = 3,
                    Number = "1d2"
                });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationObject {
                    Blueprint = "Urman",
                    Weight = 1,
                    Number = "1d1"
                });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationTable {
                    Name = "AndroidShepherdHerd",
                    Weight = 1
                });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationTable { Name = "FaerieGroupBlue", Weight = 1 });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationTable { Name = "LesserChimeras", Weight = 1 });
            Static
                .AddToPopTable("Tier5CaveCreatures",
                new PopulationObject {
                    Blueprint = "TT_Ectomorph",
                    Weight = 2,
                    Number = "3d3"
                });
            AddToPopulation("Tier3CavePopulation",
            "Agolmaggot",
            new PopulationObject {
                Blueprint = "Secluded Witch",
                Weight = 1,
                Number = "1d1"
            },
            new PopulationObject {
                Blueprint = "Moonkoi Fish",
                Weight = 1,
                Number = "1d2"
            },
            new PopulationTable { Name = "AndroidShepherdHerd", Weight = 1 });
            AddToPopulation("Tier4CavePopulation",
            "Humor",
            new PopulationObject {
                Blueprint = "Moonkoi Fish",
                Weight = 1,
                Number = "1d2"
            },
            new PopulationTable { Name = "FaerieGroup", Weight = 1 },
            new PopulationTable { Name = "AndroidSocialiteGroup", Weight = 1 });
            AddToPopulation("Tier6CavePopulation",
            "Vantabud",
            new PopulationObject {
                Blueprint = "TT_Ectomorph",
                Weight = 2,
                Number = "3d3"
            },
            new PopulationTable { Name = "LesserChimeras", Weight = 1 });
            AddToPopulation("Tier7CavePopulation",
            "Lithofex",
            new PopulationObject {
                Blueprint = "TT_Ectomorph",
                Weight = 2,
                Number = "3d3"
            },
            new PopulationObject {
                Blueprint = "FaerieBlue",
                Weight = 2,
                Number = "1d3"
            },
            new PopulationTable { Name = "AndroidMechaniteGroup", Weight = 1 },
            new PopulationTable { Name = "LesserChimeras", Weight = 1 },
            new PopulationTable { Name = "GreaterChimeras", Weight = 1 });
            AddToPopulation("Tier8CavePopulation",
            "Vantabloom",
            new PopulationObject {
                Blueprint = "Urman",
                Weight = 1,
                Number = "1d1"
            },
            new PopulationTable { Name = "FaerieGroupBlue", Weight = 1 },
            new PopulationTable { Name = "LesserChimeras", Weight = 1 },
            new PopulationTable { Name = "GreaterChimeras", Weight = 1 });

            // Roots, Trees & Flora
            Static
                .AddToPopTable("JungleVegetation_Underground",
                new PopulationObject {
                    Blueprint = "Boomrose Bush",
                    Chance = "15",
                    Number = "3d3+3"
                });
            Static
                .AddToPopTable("JungleVegetation_Underground",
                new PopulationObject {
                    Blueprint = "Mimingo",
                    Chance = "10",
                    Number = "3d3+3"
                });
            Static
                .AddToPopTable("JungleVegetation_Underground",
                new PopulationObject {
                    Blueprint = "Fleur de Lys Flower",
                    Chance = "3",
                    Number = "1d1"
                });
            Static
                .AddToPopTable("JungleVegetation_Underground",
                new PopulationObject {
                    Blueprint = "TT_Grimshoot",
                    Chance = "50",
                    Number = "6d6"
                });
            Static
                .AddToPopTable("JungleVegetation_Underground",
                new PopulationObject {
                    Blueprint = "TT_Skyvines",
                    Chance = "50",
                    Number = "6d6"
                });
            Static
                .AddToPopTable("PlainsVegetation_Underground",
                new PopulationObject {
                    Blueprint = "Boomrose Bush",
                    Chance = "15",
                    Number = "3d3+3"
                });
            Static
                .AddToPopTable("PlainsVegetation_Underground",
                new PopulationObject {
                    Blueprint = "Bittergrette Bush",
                    Chance = "35",
                    Number = "3d6+2"
                });
            Static
                .AddToPopTable("PlainsVegetation_Underground",
                new PopulationObject {
                    Blueprint = "Tears of Chloris",
                    Chance = "1",
                    Number = "1d1"
                });
            Static
                .AddToPopTable("PlainsVegetation_Underground",
                new PopulationObject {
                    Blueprint = "TT_Grimshoot",
                    Chance = "50",
                    Number = "6d6"
                });
            Static
                .AddToPopTable("PlainsVegetation_Underground",
                new PopulationObject {
                    Blueprint = "TT_Skyvines",
                    Chance = "50",
                    Number = "6d6"
                });

            // Miscellaneous
            Static
                .AddToPopTable("RandomFaction",
                new PopulationObject { Blueprint = "Androids" });
            Static
                .AddToPopTable("RandomFaction",
                new PopulationObject { Blueprint = "Metropolitans" });
        }
    }
}
