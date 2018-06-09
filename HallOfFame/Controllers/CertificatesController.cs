using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HallOfFame.Models;

namespace HallOfFame.Controllers
{
    public class CertificatesController : Controller
    {
        private ApplicationDbContext _context;

        public CertificatesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult ShowCertificates()
        {
            var certificates = _context.Certificates.Include(c => c.Domains).Include(c => c.CertificateInstitutions).ToList();
            return View("Certificates", certificates);
        }
    }
}