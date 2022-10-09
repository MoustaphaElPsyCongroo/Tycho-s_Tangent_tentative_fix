using System;
using XRL.Core;
using XRL.Rules;

namespace XRL.World.Parts
{
	[Serializable]
	public class AnimatedMaterialNeon2 : IPart
	{
		public int nFrameOffset;

		public AnimatedMaterialNeon2()
		{
			base.Name = "AnimatedMaterialNeon2";
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
				E.ColorString = "&Y";
			}
			else if (num < 40)
			{
				E.ColorString = "&O";
			}
			else if (num < 45)
			{
				E.ColorString = "&W";
			}
			else
			{
				E.ColorString = "&o";
			}
			return true;
		}
	}
}
