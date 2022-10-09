using System;
using XRL.Core;
using XRL.World.Parts;

namespace XRL.World.QuestManagers
{
	[Serializable]
	internal class BringPyreAPearl : QuestManager
	{
		public override void OnQuestAdded()
		{
			foreach (GameObject @object in (XRLCore.Core.Game.Player.Body.GetPart("Inventory") as Inventory).GetObjects())
			{
				if (@object.Blueprint == "Moonpearl")
				{
					XRLCore.Core.Game.FinishQuestStep("Tears of Heaven", "Obtain a Pearl");
				}
			}
			XRLCore.Core.Game.Player.Body.AddPart(this);
			XRLCore.Core.Game.Player.Body.RegisterPartEvent(this, "Took");
		}

		public override void OnQuestComplete()
		{
			IComponent<GameObject>.ThePlayer.RemovePart(this);
		}

		public override GameObject GetQuestInfluencer()
		{
			return GameObject.findByBlueprint("Master Pyre");
		}

		public override bool FireEvent(Event E)
		{
			if (E.ID == "Took")
			{
				foreach (GameObject item in (IComponent<GameObject>.ThePlayer.GetPart("Inventory") as Inventory).GetObjectsDirect())
				{
					if (item.Blueprint == "Moonpearl")
					{
						XRLCore.Core.Game.FinishQuestStep("Tears of Heaven", "Obtain a Pearl");
					}
				}
			}
			return base.FireEvent(E);
		}
	}
}
