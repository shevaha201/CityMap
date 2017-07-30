using System;

namespace CityMap.Model {
	public class HistoricalObject : BaseObject {

		public string Description { get; set; }

		public HistoricalObject(string name, int x, int y, string description = null)
			: base(name, x, y){

			Description = description ?? "Uknown";
		}

		public override string ToString() {
			return base.ToString() + " " + string.Format($"{Description}");
		}
	}
}
