using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models
{
	class GameStatus
	{
		#region Game-specific status

		public void IsBeaten(bool beaten)
		{
			Console.WriteLine(beaten ? "This game has been played to completion." : "This game has not ben beaten.");
		}
		public void IsVirtualCopy(bool virtualCopy)
		{
			Console.WriteLine(virtualCopy ? "This game title does not have an accessible virtual copy." : "This game title has an accessible virtual copy.");
		}
		#endregion


		

	}
}
