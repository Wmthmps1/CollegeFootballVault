using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CollegeFootballVault.Models
{
	public class Team_Record
	{
        public int year { get; set; }
		public string team { get; set; }
		public string conference { get; set; }
		public int totalWins { get; set; }
		public int totalLosses { get; set; }
		public int confWins { get; set; }
		public int confLosses { get; set; }
        public int homeWins { get; set; }
        public int homeLosses { get; set; }
        public int awayWins { get; set; }
        public int awayLosses { get; set; }

		public string getConference(string team, int year)
		{

		}
    }

	}


