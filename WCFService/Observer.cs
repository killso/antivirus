using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace WCFService
{
    public class Observer
    {
        private bool started = false;

        private FileSystemWatcher watcher;
        private List<string> viruses;

        public bool start(string path)
        {
            if (this.started) return false;
            this.started = true;

            this.viruses = new List<string>();

            this.watcher = new FileSystemWatcher();
            this.watcher.Path = path;
            this.watcher.NotifyFilter = NotifyFilters.LastWrite;
            this.watcher.Filter = "*";
            this.watcher.Changed += new FileSystemEventHandler(this.on_changed);
            this.watcher.EnableRaisingEvents = true;
            this.watcher.IncludeSubdirectories = true;
            return true;
        }

        public void stop()
        {
            if (this.started) this.watcher.Dispose();
            this.started = false;
        }

        public bool get_status()
        {
            return this.started;
        }

        public string[] result()
        {
            return viruses.ToArray();
        }

        private void on_changed(object source, FileSystemEventArgs e)
        {
            string path = e.FullPath;
            Thread.Sleep(3000);

            bool isFile = File.Exists(path);
            if (!isFile) return;

            if (!VirusDetector.detect(path)) return;

            if (!this.viruses.Contains(path)) {
                this.viruses.Add(path);
            }
        }
    }
}
