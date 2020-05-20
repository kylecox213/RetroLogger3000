using System;
using System.Collections.Generic;

namespace RetroLogger3000.Models
{
    public class Game
    {
		public int ID { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
		public int Rank { get; set; }
		public bool Clean { get; set; }
		public bool Complete { get; set; }
		public bool Beaten { get; set; }
		public bool Duplicate { get; set; }


		public virtual ICollection<GameConsole> GameConsoles { get; set; }
    }
}