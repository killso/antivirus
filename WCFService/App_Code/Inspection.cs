﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Inspection
/// </summary>
public class Inspection
{
    public Inspection() { }
    public string path;
    public int id;
    public DateTime time;

    public Inspection(string path, DateTime time, int id = -1)
    {
        this.id = id;
        this.path = path;
        this.time = time;
    }

    static public string getTimeStringFormat(DateTime time)
    {
        return time.ToString("yyyy-MM-dd|HH:mm");
    }

    static public DateTime getTimeFromStringFormat(string stringTime)
    {
        string[] date = stringTime.Split('|')[0].Split('-');
        string[] time = stringTime.Split('|')[1].Split(':');
        int year = Int32.Parse(date[0]);
        int month = Int32.Parse(date[1]);
        int day = Int32.Parse(date[2]);
        int hour = Int32.Parse(time[0]);
        int min = Int32.Parse(time[1]);
        DateTime datetime = new DateTime(year, month, day, hour, min, 0);
        return datetime;
    }
}