using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RetroLogger3000.Models
{
    public class GamePad
    {
		public int ID { get; set; }

		[Required]
		[StringLength(25, ErrorMessage = "Gamepad type cannot exceed 25 characters.")]
		public string Type { get; set; }

		[StringLength(25, MinimumLength = 3)]
		public string Model { get; set; }

		public bool Functional { get; set; }

		public virtual Game Game { get; set; }
		public virtual GameConsole GameConsoles { get; set; }
	}
}