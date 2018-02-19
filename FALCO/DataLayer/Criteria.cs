using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    
    public class Criteria
    {
        public Criteria()
        {
            Id = new Guid();
            Creation = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public String Title { get; set; }

        public DateTime Creation { get; set; }

        public virtual List<Criteria> Criterias{ get; set; }
    }
}
