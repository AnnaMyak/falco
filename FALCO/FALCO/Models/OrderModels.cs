using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FALCO.Models
{
    public class OrderModels
    {
        [Required]
        [MaxLength(40)]
        public String Organ { get; set; }

        [Required]
        [MaxLength(40)]
        public String Tissue { get; set; }

        [Required]
        [MaxLength(20)]
        public String Stain { get; set; }

        [Required]
        [Range(0, 255)]
        public int Value { get; set; }

        [Required]
        [Range(1, 100)]
        public double Acceptance { get; set; }

        public DateTime Creation { get; set; }
    }
}