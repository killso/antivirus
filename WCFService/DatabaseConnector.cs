using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;

namespace WCFService
{
    public class DatabaseConnector
    {
        private static string source = @"C:\ServiceSherbakova\DatabaseSherbakova.db";

        public DatabaseConnector() { }

        public static List<Virus> get_viruses(string signature, int position)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            List<Virus> viruses = new List<Virus>();
            var command = connection.CreateCommand();
            command.CommandText = $@"
                SELECT * FROM Viruses 
                    WHERE signature Like '{signature}%' 
                                AND offsetBegin <= {position} 
                                AND offsetEnd >= {position}
            ";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Virus virus = new Virus(
                            Int32.Parse(reader.GetString(0)),
                            reader.GetString(1),
                            reader.GetString(2),
                            Int32.Parse(reader.GetString(3)),
                            Int32.Parse(reader.GetString(4))
                    );
                    viruses.Add(virus);

                }
            }
            connection.Close();
            return viruses;
        }



        // плановые проверки
        public static List<Inspection> get_inspections()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            List<Inspection> inspections = new List<Inspection>();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM ScheduledInspections";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Inspection inspection = new Inspection(
                        reader.GetString(1),
                        DateTime.Parse(reader.GetString(2)),
                        Int32.Parse(reader.GetString(0)),
                        Boolean.Parse(reader.GetString(3))
                    );
                    inspections.Add(inspection);
                }
            }
            connection.Close();
            return inspections;
        }

        public static void add_inspection(Inspection inspection)
        {
            List<Inspection> ins = get_inspections();
            foreach (Inspection i in ins)
            {
                bool haveThisTime = i.time.ToString().Equals(inspection.time.ToString());
                bool haveThisPath = i.path.Equals(inspection.path);
                if (haveThisTime && haveThisPath)
                    return;
            }

            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"insert into ScheduledInspections(path, datetime, done) values(\"{inspection.path}\", \"{inspection.time.ToString()}\", \"false\")";
            command.ExecuteScalar();
            connection.Close();

            return;
        }

        public static void remove_inspection(Inspection inspection)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM ScheduledInspections WHERE id = {inspection.id}";
            command.ExecuteScalar();
            
            connection.Close();
        }

        public static void change_inspection_to_done(Inspection inspection)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"update ScheduledInspections SET Done = \"true\" WHERE id = {inspection.id}";
            command.ExecuteScalar();
            connection.Close();
        }







        // результаты плановых проверок
        public static void add_to_inspections_results(int inspection_id, string path)
        {
            List<string> results = get_inspection_results(inspection_id);
            for (int i = 0; i < results.Count; i += 1)
            {
                if (results[i].Equals(path)) return;
            }
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"insert into InspectionsResults(inspection_id, filepath) values({inspection_id}, \"{path}\")";
            command.ExecuteScalar();
            connection.Close();
        }

        public static void remove_inspection_result(string path)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM InspectionsResults WHERE filepath = '{path}'";
            command.ExecuteScalar();
            connection.Close();
        }

        public static void remove_inspection_results(int inspection_id)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM InspectionsResults WHERE inspection_id = {inspection_id}";
            command.ExecuteScalar();
            connection.Close();
        }

        public static List<string> get_inspection_results(int inspection_id)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            List<string> viruses = new List<string>();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM InspectionsResults where inspection_id = {inspection_id}";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    viruses.Add(reader.GetString(2));
                }
            }
            connection.Close();
            return viruses;
        }




        // карантин
        public static void add_to_quarantine(string path)
        {
            List<string> q = get_quarantine();
            if (q.Contains(path)) return;

            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"insert into Quarantine(path) values(\"{path}\")";
            command.ExecuteScalar();
            connection.Close();
        }

        public static void remove_from_quarantine(string path)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM Quarantine WHERE path = '{path}'";
            command.ExecuteScalar();
            connection.Close();
        }

        public static List<string> get_quarantine()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
            List<string> quarantine = new List<string>();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM Quarantine";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    quarantine.Add(reader.GetString(1));
                }
            }
            connection.Close();
            return quarantine;
        }
    }
}
