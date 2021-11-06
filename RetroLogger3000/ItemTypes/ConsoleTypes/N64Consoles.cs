﻿using RetroLogger3000.Interfaces;
using RetroLogger3000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.ConsoleTypes
{
	public class N64Consoles : GameConsole, IItemStatus
	{
		public N64Consoles() { }
		public N64Consoles(int consoleID, string consoleModel, int releaseYear, string manufacturer) : base(consoleID, consoleModel, releaseYear, manufacturer) { }

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
