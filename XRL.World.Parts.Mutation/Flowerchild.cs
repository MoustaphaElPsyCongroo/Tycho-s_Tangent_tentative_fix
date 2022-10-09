using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class Flowerchild : BaseMutation
    {
        public Flowerchild()
        {
            this.DisplayName = "&OF&Wl&oo&Ow&We&or&bc&Bh&bi&Bl&bd";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yTheir cherubic visages, painted by the pollen of the fields, outshine even the sun as their playful nature uproots the dormant feral lahs and resting river nymphs. The children of the meadows are loved and treasured by all suncrawlers; truly, they are blessed.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &Cflowers, Naphtaali, hindren of Bey Lah, and all manner of suncrawlers \n&y- reputation with &Cbears, unshelled reptiles, dogs, and all manner of deepdwellers";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_Flowerchild");
                return true;
            }
            return false;
        }
    }
}
