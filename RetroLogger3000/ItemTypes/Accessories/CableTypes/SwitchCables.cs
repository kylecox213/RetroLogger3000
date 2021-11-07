using RetroLogger3000.Interfaces;
using RetroLogger3000.Models;
using RetroLogger3000.Models.Accessories;

namespace RetroLogger3000.ItemTypes.Accessories.CableTypes
{
	public class SwitchCables : Cable, IItemStatus
	{
		public SwitchCables() { }
		public SwitchCables(int cableID, string cableModel, string manufacturer) : base(cableID, cableModel, manufacturer) { }

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
