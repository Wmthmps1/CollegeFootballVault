using System;
using System.Data;
using Dapper;

namespace CollegeFootballVault.Models
{
	public class SchoolRepo : ISchoolRepo
	{
        private readonly IDbConnection _conn;


        public SchoolRepo(IDbConnection conn)
		{
            _conn = conn;
        }

        public IEnumerable<Teams> GetTeams()
        {
            return _conn.Query<Teams>("SELECT * FROM SCHOOLS");
        }

        public Teams GetTeamInfo()
        {
            throw new NotImplementedException();
        }

        public string GetConference(string teamName)
        {
            throw new NotImplementedException();
        }

        public Rankings GetRankings(string teamName, int year, string conference)
        {
            throw new NotImplementedException();
        }

        

        
    }
}

