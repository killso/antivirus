using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Web;

/// <summary>
/// Сводное описание для SheduledInspector
/// </summary>
public class SheduledInspector
{
    public System.Timers.Timer timer;

    public SheduledInspector() { }

    public void start_watching()
    {
        timer = new System.Timers.Timer();
        timer.Interval = 30000;
        timer.Elapsed += try_scheduled_inspections;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private void try_scheduled_inspections(Object source, ElapsedEventArgs e)
    {
        DatabaseConnector db = new DatabaseConnector();
        List<Inspection> inspections = db.get_all_inspections();
        foreach (Inspection inspection in inspections)
        {
            DateTime now = DateTime.Now;
            bool isShouldInspect = Inspection.getTimeStringFormat(now).Equals(Inspection.getTimeStringFormat(plan.time));
            if (isShouldInspect)
            {
                Thread inspectThread = new Thread(new ThreadStart(
                    () => this.start_inspection(inspection)
                ));
                inspectThread.Start();
            }
        }
    }


    private void start_inspection(Inspection inspection)
    {
        DatabaseConnector db = new DatabaseConnector();
        db.remove_inspection(inspection);

        Scanner scanner = new Scanner();
        scanner.start(inspection.path);


        //while (scanner.getScanStatus()) { }

        string[] result = scanner.get_results();

        if (result.Length <= 1) return;

        db.add_to_inspections_result(result, inspection);
    }
}