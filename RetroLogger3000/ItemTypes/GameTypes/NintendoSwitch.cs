using RetroLogger3000.Interfaces;
using RetroLogger3000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.ItemTypes.GameTypes
{
	public class NintendoSwitch : Game, IGameStatus
	{
		public NintendoSwitch() { }
		public NintendoSwitch(int gameID, string title, int releaseYear, string platform, string publisher, string developer, int rank, int score)
			: base(gameID, title, releaseYear, platform, publisher, developer, rank, score) { }

		private GameStatus gameStatus = new GameStatus();
		private ItemStatus itemStatus = new ItemStatus();
		private AcquisitionStatus acquisitionStatus = new AcquisitionStatus();

		public void GetGameItemStatus(bool itemState)
		{
			itemStatus.IsAcquired(itemState);
			itemStatus.IsComplete(itemState);
			itemStatus.IsClean(itemState);
			itemStatus.IsDamaged(itemState);
			itemStatus.HasDuplicate(itemState);
		}

		public void GetGameStatus(bool gameState)
		{
			gameStatus.IsBeaten(gameState);
			gameStatus.IsVirtualCopy(gameState);
		}

		public void GetGameAcquisitionStatus(bool acquisitionState)
		{
			acquisitionStatus.OnWishList(acquisitionState);
		}
	}
}
