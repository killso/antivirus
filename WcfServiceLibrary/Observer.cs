using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

/// <summary>
/// Сводное описание для Observer
/// </summary>
public class Observer
{
    private bool started;

    private FileSystemWatcher watcher;
    private List<string> viruses;

    public Observer()
    {
        started = false;
    }

    public void start(string path)
    {
        if (started) stop();
        started = true;

        viruses = new List<string>();

        watcher = new FileSystemWatcher();
        watcher.Path = path;
        watcher.NotifyFilter = NotifyFilters.LastWrite;
        watcher.Filter = "*";
        watcher.Changed += new FileSystemEventHandler(on_changed);
        watcher.EnableRaisingEvents = true;
        watcher.IncludeSubdirectories = true;
    }

    public void stop()
    {
        if (started) watcher.Dispose();
        started = false;
    }

    public List<string> get_results()
    {
        return viruses;
    }

    private void on_changed(object source, FileSystemEventArgs e)
    {
        string path = e.FullPath;
        Thread.Sleep(3000);
        bool isFile = System.IO.File.Exists(path);
        if (!isFile) return;

        bool isVirus = VirusDetector.detect(path);

        if (!isVirus) return;

        bool isContained = viruses.Contains(path);
        if (!isContained)
        {
            viruses.Add(path);
        }
    }
}