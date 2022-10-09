using XRL;
using System;
// Thank Pyre for this garbage because I would've ripped mine own head off 
namespace TychoMod
{
  public static class Static
  {
    // Helper method to fudge into the most common/simple pop tables.
    public static bool AddToPopTable(string table, params PopulationItem[] items) {
        PopulationInfo info;
        if (!PopulationManager.Populations.TryGetValue(table, out info))
            return false;

        // If this is a single group population, add to that group.
        if (info.Items.Count == 1 && info.Items[0] is PopulationGroup) {
            var group = info.Items[0] as PopulationGroup;
            group.Items.AddRange(items);
            return true;
        }

        info.Items.AddRange(items);
        return true;
    }
  }
}
