using RetroLogger3000.Interfaces;
using RetroLogger3000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.ItemTypes.GamePadTypes
{
	public class XBoxGamePads : GamePad, IItemStatus
	{
		public XBoxGamePads() { }
		public XBoxGamePads(int gamePadID, string gamePadModel, int releaseYear, string manufacturer) : base(gamePadID, gamePadModel, releaseYear, manufacturer) { }

		private ItemStatus itemStatus = new ItemStatus();
		private AcquisitionStatus acquisitionStatus = new AcquisitionStatus();

		public void GetItemStatus(bool itemState)
		{
			itemStatus.IsAcquired(itemState);
			itemStatus.IsClean(itemState);
			itemStatus.IsDamaged(itemState);
			itemStatus.HasDuplicate(itemState);
		}

		public void GetItemAcquisitionStatus(bool acquisitionState)
		{
			acquisitionStatus.OnWishList(acquisitionState);
		}
	}
}
