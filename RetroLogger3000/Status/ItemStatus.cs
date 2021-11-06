using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models
{
	class ItemStatus
	{
		#region Item-specific status
		public void IsAcquired(bool acquired)
		{
			Console.WriteLine(acquired ? "Item has been acquired." : "Item has not been acquired.");
		}
		public void IsComplete(bool complete)
		{
			Console.WriteLine(complete ? "This item has all of the materials that were included upon purchase." : "This item does not have all materials to be complete.");
		}
		public void IsClean(bool clean)
		{
			Console.WriteLine(clean ? "This item has been thoroughly cleaned." : "This item has not ben cleaned.");
		}
		public void IsDamaged(bool damage)
		{
			Console.WriteLine(damage ? "This item does not have any observable cosmetic or functional damage." : "This item has observable cosmetic or functional damage.");
		}
		public void HasDuplicate(bool duplicate)
		{
			Console.WriteLine(duplicate ? "There is only one of these items in inventory." : "There is more than one of this item in inventory.");
		}
		#endregion
	}
}
