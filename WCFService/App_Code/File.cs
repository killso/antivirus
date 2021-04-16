using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для File
/// </summary>
public enum FileStates
{
    Allow,
    ToQuarantine,
    FromQuarantine,
    Delete
}

public class File
{
    public int id;
    public string path;
    public FileStates state;


    public File(string path)
    {
        this.state = FileStates.Allow;
    }

    public bool handleState()
    {
        switch(this.state)
        {
            case FileStates.ToQuarantine:
                return move_to_quarantine(this.path);
            case FileStates.FromQuarantine:
                return remove_to_quarantine(this.path);
            case FileStates.Delete:
                return delete(this.path);
            default:
                return true;
        }
    }

    static public bool move_to_quarantine(string pathname = "") 
    {
        try
        {
            byte newByte = 0x1;
            using (var newFile = new System.IO.FileStream(pathname, System.IO.FileMode.CreateNew, System.IO.FileAccess.Write))
            {

                newFile.WriteByte(newByte);
                using (var oldFile = new System.IO.FileStream(pathname, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    oldFile.CopyTo(newFile);
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    static public bool remove_to_quarantine(string pathname = "") 
    {
        try
        {
            byte[] bytes = System.IO.File.ReadAllBytes(pathname);
            byte[] newBytes = new byte[bytes.Length - 1];
            bytes.Skip(1).ToArray().CopyTo(newBytes, 0);
            System.IO.File.WriteAllBytes(pathname, newBytes);
            return true;
        }
        catch
        {
            return false;
        }
    }

    static public bool delete(string pathname = "") 
    { 
        try
        {
            System.IO.File.Delete(pathname);
            return true;
        } catch 
        {
            return false;
        }
    }
}