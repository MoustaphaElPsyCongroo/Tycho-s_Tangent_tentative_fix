using System;
using XRL.UI;

namespace XRL.World.Parts.Mutation
{
    [Serializable]
    public class GoatfolkDescendant : BaseMutation
    {
        public GoatfolkDescendant()
        {
            this.DisplayName = "&wGoat&Wfolk &wDescendant";
        }

        public override bool CanLevel()
        {
            return false;
        }

        public override string GetDescription()
        {
            return "&yGiven your foul temper it is barely of note when you reveal your ancestral roots to have been intertwined and subsequently entangled with those of the hairy beastmen of Qud's green havens. The thrill of the hunt, too, boils deep in your veins.";
        }

        public override string GetLevelText(int Level)
        {
            return "+ reputation with &Cgoatfolk, antelopes, baboons, unshelled reptiles, swine \n&y- reputation with &Call villagers, Naphtaali, Fellowship of Wardens, apes, cats, succulents, hermits";
        }

        public override bool Mutate(GameObject GO, int Level)
        {
            if (GO.IsPlayer())
            {
                GO.EquipFromPopulationTable("StartingGear_GoatfolkDescendant");
                return true;
            }
            return false;
        }
    }
}
