using System;
using System.IO;
using System.Linq;

namespace WCFService
{
    public class FileHandler
    {
        public FileHandler() { }

        static public bool addFileToQuarantine(string filePath)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(filePath);
                byte[] changed = new byte[bytes.Length + 1];
                changed[0] = 0x1;
                bytes.CopyTo(changed, 1);
                File.WriteAllBytes(filePath, changed);
            }
            catch { return false; }
            return true;
        }

        static public bool removeFileFromQuarantine(string filePath)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(filePath);
                byte[] changedBytes = new byte[bytes.Length - 1];
                bytes.Skip(1).ToArray().CopyTo(changedBytes, 0);
                File.WriteAllBytes(filePath, changedBytes);

            }
            catch { return false; }
            return true;
        }

        static public bool deleteFile(string filePath)
        {
            try
            {
                File.Delete(filePath);
                return true;
            }
            catch (UnauthorizedAccessException _e)
            {
                return false;
            }
        }
    }
}