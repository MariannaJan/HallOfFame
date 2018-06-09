using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfFame.Models
{
    public class Certificates
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public Domains Domains { get; set; }
        public int DomainsId { get; set; }
        public CertificateInstitutions CertificateInstitutions { get; set; }
        public int CertificateInstitutionsId { get; set; }
    }
}