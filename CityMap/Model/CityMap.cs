using System.Linq;
using System.Collections.Generic;
using System;

namespace CityMap.Model {
	public class CityMap {

		private static Location _currentLocation = new Location { X = 0, Y = 0};
		public static Location CurrentLocation { get { return _currentLocation; } }

		private ICollection<BaseObject> _objects;

		public CityMap() {
			_objects = new List<BaseObject>();
		}

		public void AddObject(BaseObject baseObject) {
			_objects.Add(baseObject);
		}

		public BaseObject GetObject(int objectId) {
			return _objects
				.Where(t => t.Id == objectId)
				.SingleOrDefault();
		}

		public void RemoveObject(int objectId) {
			BaseObject removedObject = _objects
				.Where(t => t.Id == objectId)
				.SingleOrDefault();

			if (removedObject != null)
				_objects.Remove(removedObject);
		}

		public ICollection<BaseObject> GetObjects() {
			return _objects;
		}

		public float GetDistance(BaseObject toObject) {
			return GetDistance(CurrentLocation.X, CurrentLocation.Y, toObject.Location.X, toObject.Location.Y);
		}

		public float GetDistance(BaseObject fromObject, BaseObject toObject) {
			return GetDistance(fromObject.Location.X, fromObject.Location.Y, toObject.Location.X, toObject.Location.Y);
		}

		private float GetDistance(int x0, int y0, int x1, int y1) {
			return (float)Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2));
		}
	}
}
