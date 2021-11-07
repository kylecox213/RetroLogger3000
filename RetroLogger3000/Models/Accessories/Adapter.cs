using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models.Accessories
{
	public abstract class Adapter
	{
		public Adapter(int adapterID = 0, string adapterModel = "", string manufacturer = "")
		{
			this.AdapterID = adapterID;
			this.AdapterModel = adapterModel;
			this.Manufacturer = manufacturer;
		}

		public int AdapterID { get; set; }
		public string AdapterModel { get; set; }
		public string Manufacturer { get; set; }
	}
}
