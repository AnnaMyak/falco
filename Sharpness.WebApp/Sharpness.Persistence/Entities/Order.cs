using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpness.Persistence.Entities
{
    public class Order
    {
        public Order()
        {
            OrderId = new Guid().ToString();
            Creation = DateTime.Now;
        }
        [Key]
        public string OrderId { get; set; }
        public string OrganId { get; set; }
        public string StainId { get; set; }
        public string TissueId { get; set; }
        public int ThresholdValue { get; set; }
        public string MetricId { get; set; }
        public DateTime Creation { get; set; }


        public ICollection<Report> Reports { get; set; }
        public Metric Metric { get; set; }


    }
}
