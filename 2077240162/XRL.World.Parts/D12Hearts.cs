using System;
using XRL.Core;
using XRL.Rules;

namespace XRL.World.Parts
{
	[Serializable]
	public class D12Hearts : IPart
	{
		public int nFrameOffset;

		public D12Hearts()
		{
			base.Name = "D12Hearts";
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
				E.ColorString = "&Y";
			}
			else if (num < 6)
			{
				E.ColorString = "&y";
			}
			else if (num < 9)
			{
				E.ColorString = "&Y";
			}
			else
			{
				E.ColorString = "&M";
			}
			return true;
		}
	}
}
