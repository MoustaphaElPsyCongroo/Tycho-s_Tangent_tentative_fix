namespace XRL
//Credit to Armithaig for this entire .cs file
{
	public static class PopulationExtensions
	{
		/// <summary>Add items to a population, next to a sibling object. </summary>
		/// <param name="table">The Name of the target population.</param>
		/// <param name="sibling">The Blueprint of the sibling object.</param>
		/// <param name="items">The items to add.</param>
		/// <returns>A boolean indicating success or failure.</returns>
		public static bool AddToPopulation(string table, string sibling, params PopulationItem[] items) {
			PopulationInfo info;
			if (!PopulationManager.Populations.TryGetValue(table, out info))
				return false;

			var group = FindGroup(info, sibling);
			if (group == null) return false;

			group.Items.AddRange(items);
			return true;
		}

		/// <summary>
		/// Recursively searches for a population group with the specified blueprint.
		/// </summary>
		public static PopulationGroup FindGroup(PopulationGroup target, string blueprint) {
			foreach (var item in target.Items) {
				var obj = item as PopulationObject;
				if (obj?.Blueprint == blueprint) return target;

				var group = item as PopulationGroup;
				if (group != null && group.Items.Count > 0) {
					group = FindGroup(group, blueprint);
					if (group != null) return group;
				}
			}

			return null;
		}

		/// <summary>
		/// Recursively searches for a population group with the specified blueprint.
		/// </summary>
		public static PopulationGroup FindGroup(PopulationInfo target, string blueprint) {
			foreach (var item in target.Items) {
				var group = item as PopulationGroup;
				if (group != null && group.Items.Count > 0) {
					group = FindGroup(group, blueprint);
					if (group != null) return group;
				}
			}

			return null;
		}
	}
}
