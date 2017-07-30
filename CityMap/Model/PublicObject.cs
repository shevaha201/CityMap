using System;

namespace CityMap.Model {
	class PublicObject : BaseObject {

		public int RateOfCrowd { get; set; }

		public PublicObject(string name, int x, int y, int rateOfCrowd = 0)
			: base (name, x, y){

			RateOfCrowd = rateOfCrowd;
		}
	}
}
