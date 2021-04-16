using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Scanner
/// </summary>
public class Scanner
{
    public Scanner() { }
    private bool started = false;

    private List<File> files;

    public void start(string path)
    {
        if (started) stop();
        bool isFile = System.IO.File.Exists(path);
        this.files = new List<File>();

        this.started = true;

        if (!isFile)
        {
            string[] entries = Array.FindAll(
                Directory.GetFiles(path, "*.*", SearchOption.AllDirectories),
                e => System.IO.File.Exists(e)
            );
            foreach (string entry_path in entries)
            {
                if (!this.started) return;
                this.files.Add(new File(entry_path));
            }
        }
        else
            this.files.Add(new File(path));

        scan_files();

        stop();
    }

    public void stop()
    {
        started = false;
    }

    private void scan_files()
    {
        foreach (File file in this.files)
        {
            if (!this.started) break;
            file.isVirus = VirusDetector.detect(file.path);
            file.isChecked = true;
        }
    }

    public string get_statistics()
    {
        string count = "Всего файлов: " + this.files.Count;

        int viruses_count = 0, count_scanned = 0;
        foreach (File virus in this.files)
        {
            if (virus.isVirus) viruses_count += 1;
            if (virus.isChecked) count_scanned += 1;
        }
        string text_count_scanned = "Проверено: " + count_scanned;
        string text_viruses_count = "Найдено уязвимостей: " + viruses_count;

        string STATISTICS = count + text_count_scanned + text_viruses_count;

        return STATISTICS;
    }

    public string[] get_results()
    {
        List<string> viruses = new List<string>();
        foreach (File file in this.files)
            if (file.isVirus) viruses.Add(file.path);

        return viruses.ToArray();
    }
}