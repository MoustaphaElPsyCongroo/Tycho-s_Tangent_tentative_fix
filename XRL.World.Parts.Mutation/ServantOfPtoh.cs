using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class ServantOfPtoh : BaseMutation
    {
        public ServantOfPtoh()
        {
            this.DisplayName = "&rServant &Wof &rPtoh";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&y'Yes, yes... indubitably. Near Quadragon Crescent you say? I shall go there and devour it. Yes I can handle it. \nOh? No matter. For Ptoh, I shall lay down my life. Now stop distracting me, I must focus.'";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &CSeekers of the Sightless Way, grazing hedonists, cragmensch, Children of Mamon \n&y- reputation with &Chighly entropic beings, Fellowship of Wardens, trolls, mollusks, baboons, cannibals, Barathrumites";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_ServantOfPtoh");
                return true;
            }
            return false;
        }
    }
}
