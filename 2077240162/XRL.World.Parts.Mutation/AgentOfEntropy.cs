using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class AgentOfEntropy : BaseMutation
    {
        public AgentOfEntropy()
        {
            this.DisplayName = "&MAgent of Entropy";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yA silent, maddening whine gnaws at the back of your mind, its tendrils ripening with malice, soon to blossom under a beetle moon into sweet midsummer carnage.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &CGlow-Wights, Girsh, highly entropic beings, cannibals \n&y- reputation with &Call villagers, Fellowship of Wardens, Putus Templar";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_AgentOfEntropy");
                return true;
            }
            return false;
        }
    }
}
