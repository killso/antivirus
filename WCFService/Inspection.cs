using System;

namespace WCFService
{
    public class Inspection
    {
        public string path;
        public int id;
        public DateTime time;
        public bool done;
        public Inspection() { }

        public Inspection(string path, DateTime time, int id = -1, bool done = false)
        {
            this.id = id;
            this.path = path;
            this.time = time;
            this.done = done;
        }
    }
}
