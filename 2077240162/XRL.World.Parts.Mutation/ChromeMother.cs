using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class ChromeMother : BaseMutation
    {
        public ChromeMother()
        {
            this.DisplayName = "&YChr&yo&Yme &yM&Yo&yther";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&R[WARNING]: INCOMPLETE. Adds unremovable 'Body' mutation. &yBorne to salt and rust with only the high salt sun as witness, you bear Shekhinah's greatest gifts - shining chr&Yo&yme husks given the false semblance of life. This vile parody which you embody is sure to attract unwanted attention amongst wilder folk.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &Candroids, Mechanimists, robots, Napthaali \n&y- reputation with &Csentient fauna";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_ChromeMother");
                return true;
            }
            return false;
        }
    }
}
