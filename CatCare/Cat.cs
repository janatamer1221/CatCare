using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCare
{
    internal class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public List<HealthRecord> HealthRecords { get; set; }
        public List<Schedule> Schedules { get; set; }

        public Cat()
        {
            HealthRecords = new List<HealthRecord>();
            Schedules = new List<Schedule>();
        }
        public string GetCareTip()
        {
            if (HealthStatus == HealthStatus.Sick)
                return "Take your cat to the vet";

            return "Your cat is healthy";
        }
    }
}
