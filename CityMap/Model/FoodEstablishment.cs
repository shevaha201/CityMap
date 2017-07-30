using System;

namespace CityMap.Model {
	public class FoodEstablishment : BaseObject {

		public TimeSpan OpenFrom { get; set; }
		public TimeSpan OpenTill { get; set; }

		public FoodEstablishment(string name, int x, int y, TimeSpan? openFrom = null, TimeSpan? openTill = null)
			: base(name, x, y){

			OpenFrom = openFrom ?? new TimeSpan(9, 0, 0); // 9:00
			OpenTill = openTill ?? new TimeSpan(21, 0, 0); // 9:00
		}

		public bool IsOpened(TimeSpan? time = null) {
			TimeSpan checkTime = time ?? DateTime.Now.TimeOfDay;
			return checkTime >= OpenFrom && checkTime <= OpenTill;
		}

		public override string ToString() {
			return base.ToString() + " " + string.Format($"Shedule({OpenFrom} - {OpenTill})");
		}

		public override bool IsVisitPossible() {
			return IsOpened();
		}
	}
}
