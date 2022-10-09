using System;
using XRL.Core;
using XRL.Rules;

namespace XRL.World.Parts
{
	[Serializable]
	public class PheliciaGlow : IPart
	{
		public int nFrameOffset;

		public PheliciaGlow()
		{
			base.Name = "PheliciaGlow";
			nFrameOffset = Stat.RandomCosmetic(0, 60);
		}

		public override bool SameAs(IPart p)
		{
			return false;
		}

		public override void Register(GameObject Object)
		{
			base.Register(Object);
		}

		public override bool Render(RenderEvent E)
		{
			int num = (XRLCore.CurrentFrame + nFrameOffset) % 60;
			nFrameOffset += Stat.RandomCosmetic(1, 5);
			if (num < 10)
			{
				E.ColorString = "&Y";
				E.DetailColor = "c";
			}
			else if (num < 14)
			{
				E.ColorString = "&W";
				E.DetailColor = "C";
			}
			else if (num < 18)
			{
				E.ColorString = "&B";
				E.DetailColor = "W";
			}
			else if (num < 32)
			{
				E.ColorString = "&Y";
				E.DetailColor = "c";
			}
			else if (num < 36)
			{
				E.ColorString = "&W";
				E.DetailColor = "B";
			}
			else
			{
				E.ColorString = "&Y";
				E.DetailColor = "C";
			}
			return true;
		}
	}
}
