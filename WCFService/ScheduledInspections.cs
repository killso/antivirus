using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Timers;

namespace WCFService
{
    public class ScheduledInspections
    {
        private System.Timers.Timer timer;

        public ScheduledInspections(){}

        public void start_watching()
        {
            timer = new System.Timers.Timer(30000);
            timer.Interval = 30000;
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            List<Inspection> inspections = DatabaseConnector.get_inspections();
            foreach (Inspection inspection in inspections)
            {
                DateTime now = DateTime.Parse(DateTime.Now.ToString());
                now = now.Subtract(new TimeSpan(0, 0, now.Second));
                bool isShouldInspect = now.ToString().Equals(inspection.time.ToString());
                if (isShouldInspect)
                {
                    Thread inspectThread = new Thread(new ThreadStart(
                        () => this.inspection(inspection)
                    ));
                    inspectThread.Start();
                }
            }
        }


        private void inspection(Inspection inspection)
        {
            Scanner scanner = new Scanner();
            scanner.start(inspection.path);

            while (scanner.get_status()) { }

            string[] result = scanner.get_results();

            for (int i = 0; i < result.Length; i += 1) {
                DatabaseConnector.add_to_inspections_results(inspection.id, result[i]);
            }

            DatabaseConnector.change_inspection_to_done(inspection);
        }
    }
}
