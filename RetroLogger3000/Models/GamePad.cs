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
		[StringLength(25, ErrorMessage = "Model type cannot exceed 25 characters.")]
		[Required]
		public string Type { get; set; }
		public string Model { get; set; }
		public bool Functional { get; set; }

		public virtual ICollection<GameConsole> GameConsoles { get; set; }
    }
}