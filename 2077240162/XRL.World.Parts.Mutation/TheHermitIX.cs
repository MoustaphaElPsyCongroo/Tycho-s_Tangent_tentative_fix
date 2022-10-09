using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class TheHermitIX : BaseMutation
    {
        public TheHermitIX()
        {
            this.DisplayName = "&YThe Herm&Wi&Yt [IX]";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&y...to share wisdom with those who seek it. To ponder on the ceaseless slaughter so-called deities daren't intervene with. Meditate. Inner reflection. Inner peace. Then, breathe deep the breath of gods, and die.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &Chermits, apes, Issachari tribe, frogs, cats, birds \n&y- reputation with &Cmysterious strangers, oozes, cannibals, fish, worms, Mechanimists, arachnids, tortoises";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_TheHermitIX");
                return true;
            }
            return false;
        }
    }
}
