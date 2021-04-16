using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Virus
/// </summary>
public class Virus
{
    public int id;
    public string signature;
    public int offsetBegin;
    public int offsetEnd;
    public Virus(int id, string signature, int offBeg, int offEnd)
    {
        this.id = id;
        this.signature = signature;
        this.offsetBegin = offBeg;
        this.offsetEnd = offEnd;
    }
}