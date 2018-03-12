using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpness.Persistence.Entities
{
    public class Organ
    {
        public Organ()
        {
            OrganId = new Guid().ToString();
            Creation = DateTime.Now;
        }
        [Key]
        public string OrganId { get; set; }
        public string Name { get; set; }
        public DateTime Creation { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
