using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class AspiringBarathrumite : BaseMutation
    {
        public AspiringBarathrumite()
        {
            this.DisplayName = "&CAspiring &YBarathrumite";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yYour parent would oft hand you tinkerbits found in the fields after long hours of toiling. You'd marvel at these 'toys,' your eyes and hands bound by their seemingly magical complexity; to say that joining the Barathrumites has been a dream ever since would be an understatement.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &CBarathrumites, Farmers' Guild, androids, robots, dogs, swine \n&y- reputation with &CMechanimists, roots, trees, worms, flowers, insects";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO
                    .EquipFromPopulationTable("StartingGear_AspiringBarathrumite");
                return true;
            }
            return false;
        }
    }
}
