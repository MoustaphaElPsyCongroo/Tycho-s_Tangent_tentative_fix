using XRL.Core;

namespace XRL.World.ZoneBuilders
{
    public class UnderbellySpire
    {
        public int RuinLevel;

        public string ZonesWide = "1";

        public string ZonesHigh = "1";

        public bool BuildZone(Zone Z)
        {
            int num = 0;
            UnderbellySpireZoneTemplate underbellySpireZoneTemplate;
            Ruiner ruiner;
            do
            {
                num++;
                ZoneManager zoneManager = XRLCore.Core.Game.ZoneManager;
                Z
                    .GetCell(0, 0)
                    .AddObject(GameObjectFactory.Factory.CreateObject("Dirty"));
                if (
                    zoneManager
                        .GetZoneColumnProperty(Z.ZoneID,
                        "Builder.Ruins.UnderbellySpireZoneTemplate") !=
                    null
                )
                {
                    underbellySpireZoneTemplate =
                        (
                        (UnderbellySpireZoneTemplate)
                        zoneManager
                            .GetZoneColumnProperty(Z.ZoneID,
                            "Builder.Ruins.UnderbellySpireZoneTemplate")
                        ).Copy();
                }
                else
                {
                    underbellySpireZoneTemplate =
                        new UnderbellySpireZoneTemplate();
                    underbellySpireZoneTemplate
                        .New(Z.Width,
                        Z.Height,
                        ZonesWide.RollCached(),
                        ZonesHigh.RollCached());
                    zoneManager
                        .SetZoneColumnProperty(Z.ZoneID,
                        "Builder.Ruins.UnderbellySpireZoneTemplate",
                        underbellySpireZoneTemplate);
                    underbellySpireZoneTemplate =
                        underbellySpireZoneTemplate.Copy();
                }
                ruiner = new Ruiner();
                Z.ClearReachableMap();
                underbellySpireZoneTemplate.GenerateRooms(Z.GetZoneZ() - 10);
            }
            while (!underbellySpireZoneTemplate.EnsureConnections(Z) && num < 20
            );
            underbellySpireZoneTemplate.BuildZone(Z, Z.GetZoneZ() > 10);
            RuinLevel = 50 - Z.GetZoneZ();
            if (RuinLevel > 0)
            {
                ruiner.RuinZone(Z, 50 - Z.GetZoneZ(), Z.GetZoneZ() > 10);
            }
            bool flag = false;
            foreach (ZoneConnection
                zoneConnection
                in
                XRLCore.Core.Game.ZoneManager.GetZoneConnections(Z.ZoneID)
            )
            {
                if (
                    zoneConnection.Type == "StairsUp" ||
                    zoneConnection.Type == "StairsDown"
                )
                {
                    flag = true;
                    Z.BuildReachableMap(zoneConnection.X, zoneConnection.Y);
                    break;
                }
            }
            if (!flag)
            {
                for (int i = 0; i < Z.Width; i++)
                {
                    for (int j = 0; j < Z.Height; j++)
                    {
                        if (!Z.GetCell(i, j).IsOccluding())
                        {
                            Z.BuildReachableMap (i, j);
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                }
            }
            if (!flag)
            {
                return false;
            }
            return true;
        }
    }
}
