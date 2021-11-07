using RetroLogger3000.Interfaces;
using RetroLogger3000.Models;
using RetroLogger3000.Models.Accessories;

namespace RetroLogger3000.ItemTypes.Accessories.PeripheralTypes
{
	public class SNESPeripherals : Peripheral, IItemStatus
	{
		public SNESPeripherals() { }
		public SNESPeripherals(int peripheralID, string peripheralModel, string manufacturer) : base(peripheralID, peripheralModel, manufacturer) { }

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
