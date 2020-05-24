using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RetroLogger3000.Models
{
    public class Game
    {
		public int ID { get; set; }

		[Required]
		[StringLength(75, ErrorMessage = "Game titles cannot be exceed 75 characters.")]
		[Column("Game Title")]
		public string Title { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Column("Release Year")]
		public int Year { get; set; }

		public int Rank { get; set; }

		public bool Clean { get; set; }

		public bool Complete { get; set; }

		public bool Beaten { get; set; }

		public bool Duplicate { get; set; }


		public virtual GameConsole GameConsoles { get; set; }
		public virtual ICollection<GamePad> GamePads { get; set; }
	}
}