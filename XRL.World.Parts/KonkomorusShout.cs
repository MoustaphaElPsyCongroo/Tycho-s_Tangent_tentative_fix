using System;
using XRL.Rules;

namespace XRL.World.Parts
{
	[Serializable]
	public class KonkomorusShout : IPart
	{
		public int OriginalLastTalk;

		public int LastTalk;

		public int QuietTimer = 55;

		public override bool SameAs(IPart p)
		{
			return false;
		}

		public override bool AllowStaticRegistration()
		{
			return true;
		}

		public override void Register(GameObject Object)
		{
			Object.RegisterPartEvent(this, "CanSmartUse");
			Object.RegisterPartEvent(this, "CommandSmartUseEarly");
			Object.RegisterPartEvent(this, "BeginTakeAction");
			base.Register(Object);
		}

		public void ZealotDeclaim(GameObject who, bool Dialog)
		{
			if (!Dialog && !ParentObject.IsAudible(IPart.ThePlayer))
			{
				return;
			}
			if (ParentObject.IsFrozen())
			{
				EmitMessage(who, "Konkomorus mumbles inaudibly, encased in ice.", Dialog);
				return;
			}
			string str = null;
			switch (Stat.Random(1, 4))
			{
			case 1:
				str = "The end is nigh!";
				break;
			case 2:
				str = "Blood! I see blood! You must seek salvation!";
				break;
			case 3:
				str = "Gather 'round, and hear my proclamation!";
				break;
			case 4:
				str = "Obey the commandments of the true Lord!";
				break;
			}
			IPart.EmitMessage(who ?? ParentObject, "Konkomorus yells &W'" + str + "'", Dialog);
			if (!Dialog)
			{
				ParentObject.ParticleText("&W" + str);
			}
		}

		public void ZealotDeclaim(bool Dialog)
		{
			ZealotDeclaim(null, Dialog);
		}

		public override bool FireEvent(Event E)
		{
			if (E.ID == "CanSmartUse")
			{
				if (ConversationScript.IsPhysicalConversationPossible(ParentObject))
				{
					if (E.GetGameObjectParameter("User").IsPlayer())
					{
						if (!ParentObject.IsPlayerLed())
						{
							return false;
						}
					}
					else if (ParentObject.InActiveZone())
					{
						return false;
					}
				}
			}
			else if (E.ID == "CommandSmartUseEarly")
			{
				if (ConversationScript.IsPhysicalConversationPossible(ParentObject))
				{
					GameObject gameObjectParameter = E.GetGameObjectParameter("User");
					if (gameObjectParameter.IsPlayer())
					{
						if (!ParentObject.IsPlayerLed())
						{
							ZealotDeclaim(gameObjectParameter, true);
						}
					}
					else if (ParentObject.InActiveZone())
					{
						ZealotDeclaim(false);
					}
				}
			}
			else if (E.ID == "BeginTakeAction" && ParentObject.InActiveZone() && IPart.Visible(ParentObject))
			{
				LastTalk--;
				if (LastTalk < 0 && Stat.Random(0, QuietTimer) == 0)
				{
					LastTalk = OriginalLastTalk;
					ZealotDeclaim(false);
				}
			}
			return base.FireEvent(E);
		}
	}
}
