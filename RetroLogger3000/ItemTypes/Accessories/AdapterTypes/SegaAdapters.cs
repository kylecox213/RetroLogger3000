﻿using RetroLogger3000.Interfaces;
using RetroLogger3000.Models;
using RetroLogger3000.Models.Accessories;

namespace RetroLogger3000.ItemTypes.Accessories.AdapterTypes
{
	public class SegaAdapters : Adapter, IItemStatus
	{
		public SegaAdapters() { }
		public SegaAdapters(int adapterID, string adapterModel, string manufacturer) : base(adapterID, adapterModel, manufacturer) { }

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
