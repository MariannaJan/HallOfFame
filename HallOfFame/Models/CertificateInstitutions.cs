using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfFame.Models
{
    public class CertificateInstitutions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public bool IssuesCertificate { get; set; }
    }
}