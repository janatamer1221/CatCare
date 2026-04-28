using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CatCare
{
    public static class DataStore
    {
        
        static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cats_data.txt");

        public static void SaveAllData(List<Cat> cats)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var cat in cats)
                    {
                        string schs = cat.Schedules != null ? string.Join("^", cat.Schedules.Select(s => $"{s.Type}|{s.Date}|{s.Notes}")) : "";
                        string hlths = cat.HealthRecords != null ? string.Join("^", cat.HealthRecords.Select(h => $"{h.Date}|{h.Status}|{h.Notes}")) : "";

                        sw.WriteLine($"{cat.Name},{cat.Age},{cat.HealthStatus},{schs},{hlths}");
                    }
                }
                
            }
            catch (Exception ex)
            {
               
            }
        }

        public static List<Cat> LoadAllData()
        {
            List<Cat> cats = new List<Cat>();
            if (!File.Exists(filePath)) return cats;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var d = line.Split(',');

                    Cat c = new Cat
                    {
                        Name = d[0],
                        Age = int.Parse(d[1]),
                        HealthStatus = (HealthStatus)Enum.Parse(typeof(HealthStatus), d[2]),
                        Schedules = new List<Schedule>(),
                        HealthRecords = new List<HealthRecord>()
                    };

                    if (d.Length > 3 && !string.IsNullOrWhiteSpace(d[3]))
                    {
                        foreach (var s in d[3].Split('^'))
                        {
                            var p = s.Split('|');
                            c.Schedules.Add(new Schedule { Type = (ScheduleType)Enum.Parse(typeof(ScheduleType), p[0]), Date = DateTime.Parse(p[1]), Notes = p[2] });
                        }
                    }

                    if (d.Length > 4 && !string.IsNullOrWhiteSpace(d[4]))
                    {
                        foreach (var h in d[4].Split('^'))
                        {
                            var p = h.Split('|');
                            c.HealthRecords.Add(new HealthRecord { Date = DateTime.Parse(p[0]), Status = (HealthStatus)Enum.Parse(typeof(HealthStatus), p[1]), Notes = p[2] });
                        }
                    }
                    cats.Add(c);
                }
            }
            catch (Exception ex)
            {
               
            }

            return cats;
        }
    }
}