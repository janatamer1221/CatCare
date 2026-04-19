using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCare
{
    internal class HealthRecord
    {
        public int CatId { get; set; }
        public DateTime Date { get; set; }
        public HealthStatus Status { get; set; }
        public string Notes { get; set; }
        
    }
}
