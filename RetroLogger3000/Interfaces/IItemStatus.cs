using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Interfaces
{
	public interface IItemStatus
	{
		void GetItemStatus(bool itemState);
		void GetItemAcquisitionStatus(bool acquisitionState);
	}
}
