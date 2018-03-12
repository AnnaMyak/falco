using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpness.Persistence.Entities
{
    public class Metric
    {
        public Metric()
        {
            Creation = DateTime.Now;
        }

        [Key]
        public string MetricId { get; set; }
        public string Name { get; set; }
        public DateTime Creation { get; set; }


        public ICollection<Order> Orders { get; set; }
    }
}
