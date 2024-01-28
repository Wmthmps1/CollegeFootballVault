using System;
using System.Collections.Generic;



namespace CollegeFootballVault.Models
{
	public interface ISchoolRepo
	{
		public IEnumerable<Teams> GetTeams();
		public Teams GetTeamInfo();
		public string GetConference(string teamName);
		public Rankings GetRankings(string teamName, int year, string conference);

	}
}

