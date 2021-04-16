using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для DatabaseConnect
/// </summary>
public class DatabaseConnector
{
    private string path;

    public DatabaseConnector()
    {
        this.path = @"C:\DatabaseSherbakova";
    }

    public List<Inspection> get_all_inspections()
    {
        return new List<Inspection>();
    }

    public void remove_inspection(Inspection inspection)
    {

    }

    public void add_to_inspections_result(string[] r, Inspection inspection)
    {

    }

    public List<Virus> get_viruses(string signature, int offset)
    {
        return new List<Virus>();
    }
}