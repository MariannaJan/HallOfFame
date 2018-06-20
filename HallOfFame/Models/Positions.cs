using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HallOfFame.Models
{
    public class Positions
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Position { get; set; }

        [Required]
        [StringLength(255)]
        public string Company { get; set; }

        [Required]
        public string Years { get; set; }

        [StringLength(255)]
        public string Duties { get; set; }
    }
}