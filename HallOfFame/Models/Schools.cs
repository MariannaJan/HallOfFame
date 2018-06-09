using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfFame.Models
{
    public class Schools
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Years { get; set; }
        public string Link { get; set; }
        public string Subject { get; set; }
    }
}