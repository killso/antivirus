using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace WCFService
{
    public class Scanner
    {
        private bool started = false;

        private List<FileDescription> files_to_scan = new List<FileDescription>();

        public bool get_status()
        {
            return this.started;
        }

        public bool start(string pathName)
        {
            if (this.started) return false;
            bool isFile = File.Exists(pathName);
            this.files_to_scan = new List<FileDescription>();

            this.started = true;

            if (!isFile)
            {
                string[] entries = Array.FindAll(
                    Directory.GetFiles(pathName, "*.*", SearchOption.AllDirectories),
                    e => System.IO.File.Exists(e)
                );

                foreach (string path in entries)
                {
                    if (!this.started) return true;
                    if (File.Exists(path))
                        this.files_to_scan.Add(new FileDescription(path));
                }
            }
            else
                this.files_to_scan.Add(new FileDescription(pathName));

            this.scanning();

            this.stop();
            return true;
        }

        public void stop()
        {
            this.started = false;
        }

        private void scanning()
        {
            foreach (FileDescription file in this.files_to_scan)
            {
                if (!this.started) break;
                file.isVirus = VirusDetector.detect(file.path);
                file.isChecked = true;
            }
        }

        public string get_statistics()
        {
            string count = "Всего файлов: " + this.files_to_scan.Count;

            int viruses_count = 0, count_scanned = 0;
            foreach (FileDescription virus in this.files_to_scan)
            {
                if (virus.isVirus) viruses_count += 1;
                if (virus.isChecked) count_scanned += 1;
            }
            string text_count_scanned = "Проверено: " + count_scanned;
            string text_viruses_count = "Найдено уязвимостей: " + viruses_count;

            string STATISTICS = count + '\r' + '\n' + text_count_scanned + '\r' + '\n' + text_viruses_count;

            return STATISTICS;
        }

        public string[] get_results()
        {
            List<string> viruses = new List<string>();
            foreach (FileDescription file in this.files_to_scan)
                if (file.isVirus) viruses.Add(file.path);

            return viruses.ToArray();
        }
    }
}
