using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class Rootdweller : BaseMutation
    {
        public Rootdweller()
        {
            this.DisplayName = "&gR&Goo&gtdwe&Gll&ger";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yRootdwellers, anthousai, the children of Chloris - the Naphtaali go by many names. Though not all rootdwellers are Naphtaali by nature; twice in a blue moon a young babe may be left on the edges of a meadow, an offering to the tribes, or to silent gods in the name of good fortune...";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &CNaphtaali, roots, vines, trees, fish, villagers of Kyakukya \n&y- reputation with &CGoatfolk, grazing hedonists, baboons, winged mammals, dromad merchants";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_Rootdweller");
                return true;
            }
            return false;
        }
    }
}
