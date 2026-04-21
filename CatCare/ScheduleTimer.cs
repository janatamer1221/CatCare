using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace CatCare
    {
        public class ScheduleTimer
        {
            private CatManager catManager;
            private Timer timer;
            public ScheduleTimer(CatManager manager)
            {
                catManager = manager;
            }

            public void Start()
            {
                timer = new Timer();
                timer.Interval = 60000; 
                timer.Elapsed += CheckSchedules;
                timer.Start();
            }

        
            private void CheckSchedules(object sender, ElapsedEventArgs e)
            {
                Cat[] cats = catManager.GetAllCats();

                foreach (Cat cat in cats)
                {
                    foreach (Schedule s in cat.Schedules)
                    {
                        if (s.IsUpcoming())
                        {
                            OnReminderTriggered(cat, s);
                        }
                    }
                }
            }

     
            private void OnReminderTriggered(Cat cat, Schedule schedule)
            {
                string type = schedule.Type == ScheduleType.Meal
                    ? "Meal"
                    : " Vaccination";

                string message = $"TAKE CARE OF YOUR CAT !\n" +
                                 $"Cat: {cat.Name}\n" +
                                 $"Type: {type}\n" +
                                 $"Time: {schedule.GetTimeRemaining()}\n" +
                                 $"Notes: {schedule.Notes}";

                Console.WriteLine(message);
            }

            public void Stop()
            {
                timer.Stop();
            }
        }
    }


