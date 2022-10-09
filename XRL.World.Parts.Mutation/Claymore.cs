using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class Claymore : BaseMutation
    {
        public Claymore()
        {
            this.DisplayName = "&YC&rlay&Ym&rore";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yThe Claymore bears a face few could forget; grim, grimy, and yet commandeering of respect. Their gaze precedes them, the experience of a hundred battles made manifest by the twitch of an eye or the crackling of a leaf.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &Cdromad merchants, Fellowship of Wardens, equines, bears, mysterious strangers \n&y- reputation with &Carachnids, crabs, snapjaws, worms, and all manner of chimeras";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_Claymore");
                return true;
            }
            return false;
        }
    }
}
