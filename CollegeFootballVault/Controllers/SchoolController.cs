using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeFootballVault.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollegeFootballVault.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolRepo repo;

        public SchoolController(ISchoolRepo repo)
        {
            this.repo = repo;
        }

        
        public IActionResult Index()
        {
            var schools = repo.GetTeams();
            return View(schools);
        }
    }
}

