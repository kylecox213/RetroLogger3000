using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models
{
	public abstract class GamePad
	{
		public GamePad(int gamePadID = 0, string gamePadModel = "", int releaseYear = 0, string manufacturer = "")
		{
			this.GamePadID = gamePadID;
			this.GamePadModel = gamePadModel;
			this.ReleaseYear = releaseYear;
			this.Manufacturer = manufacturer;
		}

		public int GamePadID { get; set; }
		public string GamePadModel { get; set; }
		public int ReleaseYear { get; set; }
		public string Manufacturer { get; set; }

		//public bool OnWishList
		//private int releaseYear;
	}
}
