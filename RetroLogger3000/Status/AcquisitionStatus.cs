using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models
{
	class AcquisitionStatus
	{
		#region Acquisition-specific status
		public void OnWishList(bool wishList)
		{
			Console.WriteLine(wishList ? "This item has been added to the wishlist." : "This item is not currently on the wishlist.");
		}
		#endregion
	}
}
