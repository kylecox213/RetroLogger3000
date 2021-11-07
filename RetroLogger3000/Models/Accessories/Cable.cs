using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models.Accessories
{
	public abstract class Cable
	{
		public Cable(int cableID = 0, string cableModel = "", string manufacturer = "")
		{
			this.CableID = cableID;
			this.CableModel = cableModel;
			this.Manufacturer = manufacturer;
		}

		public int CableID { get; set; }
		public string CableModel { get; set; }
		public string Manufacturer { get; set; }
	}
}
