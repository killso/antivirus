using System.Collections.Generic;
using System.ServiceModel;

namespace WCFService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void start_scanner(string path);

        [OperationContract]
        void stop_scanner();

        [OperationContract]
        string get_scanner_statistics();

        [OperationContract]
        string[] get_scanner_result();

        [OperationContract]
        bool get_scanner_status();



        [OperationContract]
        void start_observer(string path);

        [OperationContract]
        void stop_observer();

        [OperationContract]
        string[] get_observer_result();
        [OperationContract]
        bool get_observer_status();



        [OperationContract]
        void handle_files(List<FileDescription> files, Inspection inspection = null);



        [OperationContract]
        void add_inspection(Inspection inspection);

        [OperationContract]
        void remove_inspection(Inspection inspection);

        [OperationContract]
        List<Inspection> get_inspections();



        [OperationContract]
        List<string> get_inspection_results(Inspection inspection);


        [OperationContract]
        List<string> get_quarantine();
    }
}
