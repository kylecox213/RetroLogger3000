using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetroLogger3000.Models
{
	public class Cable
	{
		public int ID { get; set; }

		[Required]
		[Display(Name = "Cable Type")]
		public string Type { get; set; }

		public int Length { get; set; }

		public bool Functional { get; set; }

		public virtual GameConsole GameConsole { get; set; }
	}
}