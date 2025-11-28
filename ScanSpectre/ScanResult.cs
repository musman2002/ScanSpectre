namespace ScanSpectre
{
    public class ScanResult
    {
        public int Port { get; set; }
        public bool IsOpen { get; set; }
        public string Status => IsOpen ? "Open" : "Closed";
    }
}
