using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace RetroLogger3000.Models
{
    public class GamePad
    {
		public int ID { get; set; }
		public string Model { get; set; }
		public string Type { get; set; }
		public bool Functional { get; set; }

		public virtual ICollection<GameConsole> GameConsoles { get; set; }
    }
}