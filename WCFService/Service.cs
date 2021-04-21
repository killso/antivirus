using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace WCFService
{
    public class Service : IService
    {
        static public Scanner scanner = new Scanner();
        static public Observer observer = new Observer();

        public void start_scanner(string path)
        {
            Thread thread = new Thread(new ThreadStart(
                () => 
                    Service.scanner.start(path)
            ));
            thread.Start();
        }
        public void stop_scanner()
        {
            Service.scanner.stop();
        }
        public string get_scanner_statistics()
        {
            return Service.scanner.get_statistics();
        }
        public string[] get_scanner_result()
        {
            return Service.scanner.get_results();
        }
        public bool get_scanner_status()
        {
            return Service.scanner.get_status();
        }



        public void start_observer(string path)
        {
            Thread thread = new Thread(new ThreadStart(
                () => observer.start(path)
            ));
            thread.Start();
        }
        public void stop_observer()
        {
            observer.stop();
        }
        public string[] get_observer_result()
        {
            return observer.result();
        }
        public bool get_observer_status()
        {
            return observer.get_status();
        }


        public void handle_files(List<FileDescription> files, Inspection inspection = null)
        {
           try
            {
                foreach (FileDescription file in files)
                {
                    switch (file.state)
                    {
                        case FileDescription.FilesStates.Allow:
                            if (inspection != null)
                                DatabaseConnector.remove_inspection_result(file.path);
                            break;
                        case FileDescription.FilesStates.ToQuarantine:
                            FileHandler.addFileToQuarantine(file.path);
                            DatabaseConnector.add_to_quarantine(file.path);
                            if (inspection != null)
                                DatabaseConnector.remove_inspection_result(file.path);
                            break;
                        case FileDescription.FilesStates.RemoveFromQuarantine:
                            FileHandler.removeFileFromQuarantine(file.path);
                            DatabaseConnector.remove_from_quarantine(file.path);
                            if (inspection != null)
                                DatabaseConnector.remove_inspection_result(file.path);
                            break;
                        case FileDescription.FilesStates.Delete:
                            FileHandler.deleteFile(file.path);
                            DatabaseConnector.remove_from_quarantine(file.path);
                            if (inspection != null)
                                DatabaseConnector.remove_inspection_result(file.path);
                            break;
                        default:
                            break;
                    }
                }
            } finally { }
        }

        public void add_inspection(Inspection inspection)
        {
            DatabaseConnector.add_inspection(inspection);
        }

        public void remove_inspection(Inspection inspection)
        {
            DatabaseConnector.remove_inspection(inspection);
            DatabaseConnector.remove_inspection_results(inspection.id);
        }
        public List<Inspection> get_inspections()
        {
            return DatabaseConnector.get_inspections();
        }



        public List<string> get_inspection_results(Inspection inspection)
        {
            return DatabaseConnector.get_inspection_results(inspection.id);
        }

        public List<string> get_quarantine()
        {
            return DatabaseConnector.get_quarantine();
        }
    }
}
