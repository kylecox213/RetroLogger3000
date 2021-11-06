using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Interfaces
{
	public interface IGameStatus
	{
		void GetGameItemStatus(bool itemState);
		void GetGameStatus(bool gameState);
		void GetGameAcquisitionStatus(bool acquisitionState);
	}

	
}
