using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCare
{
    internal class Schedule
    {
        public int CatId { get; set; }
        public ScheduleType Type { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public bool IsUpcoming()
        {
            return Date <= DateTime.Now.AddDays(1);
        }
    }
}
