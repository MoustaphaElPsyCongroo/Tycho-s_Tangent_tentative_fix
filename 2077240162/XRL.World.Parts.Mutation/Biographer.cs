using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class Biographer : BaseMutation
    {
        public Biographer()
        {
            this.DisplayName = "&WB&wi&Wo&wg&Wr&wa&Wp&wh&We&wr";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yWords and whispers are taken from their aerobic forms and imprinted onto paper scrolls, to be forever imprisoned upon the starch walls of the Annals of Qud. Though many admire the fervor with which ink is fused with paper, the presence of a biographer is oft an unwelcome one, as they inevitably breach upon one's privacy.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &Call cults, pariahs, water barons, Mechanimists \n&y- reputation with &Ctrees, roots, cragmensch, newly sentient beings, hindren of Bey Lah";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_Biographer");
                return true;
            }
            return false;
        }
    }
}
