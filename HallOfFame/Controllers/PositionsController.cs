using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HallOfFame.Models;

namespace HallOfFame.Controllers
{
    public class PositionsController : Controller
    {
        private ApplicationDbContext _context;

        public PositionsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public PartialViewResult PosDisplay()
        {
            var positions = _context.Position.ToList();
            return PartialView("_PosDisplay", positions);
        }
    }
}