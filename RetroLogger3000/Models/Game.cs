using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroLogger3000.Models
{
	public abstract class Game
	{
		public Game(int gameID = 0, string title = "", int releaseYear = 0, string platform = "", string publisher = "", string developer = "", int rank = 0, int score = 0)
		{
			GameID = gameID;
			Title = title;
			ReleaseYear = releaseYear;
			Platform = platform;
			Publisher = publisher;
			Developer = developer;
			Rank = rank;
			Score = score;
		}

		public int GameID { get; set; }
		public string Title { get; set; }
		public int ReleaseYear { get; set; }
		public string Platform { get; set; }
		public string Publisher { get; set; }
		public string Developer { get; set; }
		public int Rank { get; set; }
		public int Score { get; set; }

		public void GetRank(int rank)
		{
			if (rank < 1)
				throw new ArgumentOutOfRangeException("Game rank can not be set to a value less than 1.");

			else if (rank > 10)
				throw new ArgumentOutOfRangeException("Game rank cannot be set to a value greater than 10.");

			else if (!(rank < 1) && !(rank > 10))
				throw new NotFiniteNumberException("Game rank must be set to a whole numeric value range between 1 and 10.");
			else
			{
				if (rank <= 0)
				{
					Exception ex = new Exception($"{Title} has not been assigned a rank value.");
				}
				else
					Console.WriteLine($"{Title} is currently ranked at {0}", Rank);
			}
		}

		public void GetScore(int score)
		{
			if (score < 1)
				throw new ArgumentOutOfRangeException("Game score can not be set to a value less than 1.");

			else if (score > 10)
				throw new ArgumentOutOfRangeException("Game score cannot be set to a value greater than 10.");

			else if (!(score < 1) && !(score > 10))
				throw new NotFiniteNumberException("Game score must be set to a whole numeric value range between 1 and 10.");
			else
			{
				if (score <= 0)
				{
					Exception ex = new Exception($"{Title} has not been assigned a score value.");
				}
				else
					Console.WriteLine($"{Title} is currently scored at {0}", Rank);
			}
		}
	}
}
