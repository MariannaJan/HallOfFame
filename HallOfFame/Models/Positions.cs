using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfFame.Models
{
    public class Positions
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string Years { get; set; }
        public string Duties { get; set; }
    }
}