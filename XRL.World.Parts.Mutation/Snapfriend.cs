using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class Snapfriend : BaseMutation
    {
        public Snapfriend()
        {
            this.DisplayName = "&wSnapf&Rr&wiend";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yFiend or friend? Friend or foe? Woe of Joppa. \n&KHark hark hark! \n&yYou one of us now!";
        }

        public override string GetLevelText(int Level)
        {
            return "&y+ reputation with &Csnapjaws, bears, dogs, trolls, oozes \n&y- reputation with &Ccivilised folk, cats, equines";
        }

        // This method is called when the "mutation" is added to a gameobject (item/creature)
        public override bool Mutate(GameObject GO, int Level)
        {
            // Is the GO that's receiving this mutation the player?
            if (GO.IsPlayer())
            {
                // If so, return true so that they get the mutation.
                // You can also add any items you want here, the proper way to do so is with the
                GO.EquipFromPopulationTable("StartingGear_Snapfriend");
                return true;
            }

            // Otherwise we return false and the GO does not get the mutation.
            return false;
        }

        // ... But you can jus' stick with the top one since ya want to add items as well inside of the if().
    }
}
