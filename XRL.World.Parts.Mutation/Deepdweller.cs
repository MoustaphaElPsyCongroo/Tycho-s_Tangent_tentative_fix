using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class Deepdweller : BaseMutation
    {
        public Deepdweller()
        {
            this.DisplayName = "&KDee&Gpd&Kweller";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yDeep within the s&rc&yarlet loam lurk the Deepdwellers, remnants of a struggle long forgotten, their pallid skins now glistening a marble red beneath glowmoth lanterns. Long since have they befriended the critters that crawl in the dark... they are halfmen by all accounts...";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &Cworms, insects, fungi, roots, crabs, arachnids \n&y- reputation with &Csome civilised folk, robots, equines";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_Deepdweller");
                return true;
            }
            return false;
        }
    }
}
