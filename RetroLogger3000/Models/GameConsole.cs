using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models
{
	public abstract class GameConsole
	{
		public GameConsole(int consoleID = 0, string consoleModel = "", int releaseYear = 0, string manufacturer = "")
		{
			ConsoleID = consoleID;
			ConsoleModel = consoleModel;
			ReleaseYear = releaseYear;
			Manufacturer = manufacturer;
		}

		public int ConsoleID { get; set; }
		public string ConsoleModel { get; set; }
		public int ReleaseYear { get; set; }
		public string Manufacturer { get; set; }
	}
}
