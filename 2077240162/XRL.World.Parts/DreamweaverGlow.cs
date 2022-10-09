using System;
using XRL.Core;
using XRL.Rules;

namespace XRL.World.Parts
{
	[Serializable]
	public class DreamweaverGlow : IPart
	{
		public int nFrameOffset;

		public DreamweaverGlow()
		{
			base.Name = "DreamweaverGlow";
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
			if (num < 5)
			{
				E.DetailColor = "Y";
			}
			else if (num < 25)
			{
				E.DetailColor = "W";
			}
			else if (num < 30)
			{
				E.DetailColor = "Y";
			}
			else
			{
				E.DetailColor = "W";
			}
			return true;
		}
	}
}
