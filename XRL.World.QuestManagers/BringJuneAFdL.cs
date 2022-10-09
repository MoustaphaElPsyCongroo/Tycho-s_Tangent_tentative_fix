using System;
using XRL.Core;
using XRL.World.Parts;

namespace XRL.World.QuestManagers
{
	[Serializable]
	internal class BringJuneAFdL : QuestManager
	{
		public override void OnQuestAdded()
		{
			foreach (GameObject @object in (XRLCore.Core.Game.Player.Body.GetPart("Inventory") as Inventory).GetObjects())
			{
				if (@object.Blueprint == "Fleur de Lys")
				{
					XRLCore.Core.Game.FinishQuestStep("A Royal Wedding", "Obtain the Flower");
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
			return GameObject.findByBlueprint("June");
		}

		public override bool FireEvent(Event E)
		{
			if (E.ID == "Took")
			{
				foreach (GameObject item in (IComponent<GameObject>.ThePlayer.GetPart("Inventory") as Inventory).GetObjectsDirect())
				{
					if (item.Blueprint == "Fleur de Lys")
					{
						XRLCore.Core.Game.FinishQuestStep("A Royal Wedding", "Obtain the Flower");
					}
				}
			}
			return base.FireEvent(E);
		}
	}
}
