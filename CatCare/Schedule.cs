using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCare
{
    public class Schedule
    {
        public int CatId { get; set; }
        public ScheduleType Type { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public bool IsUpcoming()
        {
            return Date <= DateTime.Now.AddDays(1);
        }
        public string GetTimeRemaining()
        {
            TimeSpan remaining = Date - DateTime.Now;

            if (remaining.TotalMinutes < 0)
                return "Appointment passed!";

            if (remaining.TotalHours < 1)
                return $"{(int)remaining.TotalMinutes} minutes remaining";

            if (remaining.TotalDays < 1)
                return $"{(int)remaining.TotalHours} hours remaining";

            return $"{(int)remaining.TotalDays} days remaining";
        }
    }
}

           