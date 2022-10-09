using System;
using XRL.World;
using XRL.World.WorldBuilders;

namespace TychoMod.World.WorldBuilders

{
    [JoppaWorldBuilderExtension]
    public class AgentOfEntropyReputation : IJoppaWorldBuilderExtension
    {
        public override void OnAfterBuild( JoppaWorldBuilder builder )
        {
            foreach (var faction in Factions.loop())
            {
                if(faction.Name.StartsWith("villagers of "))
                    {
                    faction.setPartReputation("AgentOfEntropy", -150);
                    faction.setPartReputation("Deepdweller", -100);
                    faction.setPartReputation("DeathXIII", -1000);
                    faction.setPartReputation("Flowerchild", 100);
                    faction.setPartReputation("GoatfolkDescendant", -150);
                    faction.setPartReputation("Snapfriend", -150);
                }
            }
        }
    }
}
