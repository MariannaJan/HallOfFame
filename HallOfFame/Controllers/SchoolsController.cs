using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HallOfFame.Models;

namespace HallOfFame.Controllers
{
    public class SchoolsController : Controller
    {

        private ApplicationDbContext _context;

        public SchoolsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public PartialViewResult Display()
        {
            var schools = _context.School.ToList();
            return PartialView("_Display",schools);
        }
    }
}