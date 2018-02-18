using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            Creation = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }

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

        public virtual List<Order> Orders { get; set; }
    }
}
