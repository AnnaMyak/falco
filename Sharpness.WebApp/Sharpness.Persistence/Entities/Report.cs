using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpness.Persistence.Entities
{
    public class Report
    {
        public Report()
        {
            ReportId = new Guid().ToString();
            Creation = DateTime.Now;
        }
        [Key]
        public string ReportId { get;  set; }
        public string UserId { get; set; }
        public byte[] SharpnessMap { get; set; }
        public int SharpArea { get; set; }
        public int BlurArea { get; set; }
        public bool Evaluation { get; set; }
        public DateTime Creation { get; set; }
        public string OrganId { get; set; }
        public string TissueId { get; set; }
        public string StainId { get; set; }
        public string OrderId { get; set; }





        public Order Order { get; set; }
        public Organ Organ{get; set;}
        public Tissue Tissue { get; set; }
        public Stain Stain { get; set; }
    }
}
