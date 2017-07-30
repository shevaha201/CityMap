using System;

namespace CityMap.Model {
	public class BaseObject {

		private static int NextId;

		public int Id { get; }
		public string Name { get; set; }
		public Location Location { get; set; }

		public BaseObject(string name, int x, int y) {
			Name = name;
			Location = new Location {
				X = x,
				Y = y
			};
		}

		private int CreateId() {
			int id = NextId;
			NextId++;
			return id;
		}

		public override string ToString() {
			return string.Format($"{Id}, {Name}, {Location}");
		}

		public virtual bool IsVisitPossible() {
			return true;
		}
	}
}
