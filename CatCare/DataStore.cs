using System;
using System.Collections.Generic;
using System.IO;

namespace CatCare
{
    public static class DataStore
    {
        private static string filePath = "cats_data.txt";

        public static void SaveAllData(List<Cat> cats)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var cat in cats)
                    {
                        // بنسيف: الاسم,العمر,الحالة
                        sw.WriteLine($"{cat.Name},{cat.Age},{cat.HealthStatus}");
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static List<Cat> LoadAllData()
        {
            List<Cat> cats = new List<Cat>();
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        var data = line.Split(',');
                        cats.Add(new Cat { Name = data[0], Age = int.Parse(data[1]) });
                    }
                }
            }
            catch (Exception ex) { }
            return cats;
        }
    }
}