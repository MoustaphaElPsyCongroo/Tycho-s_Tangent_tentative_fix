using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class DeathXIII : BaseMutation
    {
        public DeathXIII()
        {
            this.DisplayName = "&KDea&Rt&Kh [XIII]";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yI gave her my all \n\nin this final story \n\nshe survived the fall \n\nmemento mori";
        }

        public override string GetLevelText(int Level)
        {
            return "- reputation with &Cevery breathing, sentient, animate entity this godforsaken world has to offer";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_DeathXIII");
                return true;
            }
            return false;
        }
    }
}
