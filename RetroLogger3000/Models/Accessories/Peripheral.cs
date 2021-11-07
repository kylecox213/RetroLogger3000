using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models.Accessories
{
	public abstract class Peripheral
	{
		public Peripheral(int peripheralID = 0, string peripheralModel = "", string manufacturer = "")
		{
			this.PeripheralID = peripheralID;
			this.PeripheralModel = peripheralModel;
			this.Manufacturer = manufacturer;
		}

		public int PeripheralID { get; set; }
		public string PeripheralModel { get; set; }
		public string Manufacturer { get; set; }
	}
	//	public bool OnWishList;
}
