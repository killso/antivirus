namespace WCFService
{
    public class FileDescription
    {
        public string path;
        public bool isVirus;
        public bool isChecked;
        public enum FilesStates {
            Allow,
            ToQuarantine,
            RemoveFromQuarantine,
            Delete
        }
        public FilesStates state;

        public FileDescription() { }
        public FileDescription(string path)
        {
            this.isChecked = false;
            this.path = path;
            this.state = FilesStates.Allow;
        }
    }
}
