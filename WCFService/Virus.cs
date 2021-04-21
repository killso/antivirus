namespace WCFService
{
    public class Virus
    {
        public int id;
        public string name;
        public string signature;
        public int offsetBegin;
        public int offsetEnd;

        public Virus() { }
        public Virus(int id, string name, string signature, int offsetBegin, int offsetEnd)
        {
            this.id = id;
            this.name = name;
            this.signature = signature;
            this.offsetBegin = offsetBegin;
            this.offsetEnd = offsetEnd;
        }
    }
}
