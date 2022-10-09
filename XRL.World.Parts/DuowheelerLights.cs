using System;
using XRL.Core;
using XRL.Rules;

namespace XRL.World.Parts
{
	[Serializable]
	public class DuowheelerLights : IPart
	{
		public int nFrameOffset;

		public DuowheelerLights()
		{
			base.Name = "DuowheelerLights";
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
			if (num < 3)
			{
				E.ColorString = "&K";
			}
			else if (num < 10)
			{
				E.ColorString = "&G";
			}
			else if (num < 13)
			{
				E.ColorString = "&K";
			}
			else
			{
				E.ColorString = "&G";
			}
			return true;
		}
	}
}
