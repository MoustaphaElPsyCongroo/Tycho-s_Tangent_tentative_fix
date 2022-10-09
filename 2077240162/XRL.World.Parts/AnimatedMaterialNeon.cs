using System;
using XRL.Core;
using XRL.Rules;

namespace XRL.World.Parts
{
	[Serializable]
	public class AnimatedMaterialNeon : IPart
	{
		public int nFrameOffset;

		public AnimatedMaterialNeon()
		{
			base.Name = "AnimatedMaterialNeon";
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
			if (num < 15)
			{
				E.ColorString = "&M";
			}
			else if (num < 30)
			{
				E.ColorString = "&Y";
			}
			else if (num < 45)
			{
				E.ColorString = "&m";
			}
			else
			{
				E.ColorString = "&Y";
			}
			return true;
		}
	}
}
