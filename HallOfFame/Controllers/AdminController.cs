using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfFame.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        
        public ViewResult Admin()
        {
            if (User.IsInRole("Admin"))
                return View("AdminPanel");
            return View("NoEntry");
        }
    }
}