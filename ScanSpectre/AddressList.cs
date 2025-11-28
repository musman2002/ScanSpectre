using System.Collections.Generic;

namespace ScanSpectre
{
    public class AddressList
    {
        public int StartPort { get; set; }
        public int EndPort { get; set; }

        public IEnumerable<int> GetPorts()
        {
            for (int p = StartPort; p <= EndPort; p++)
            {
                yield return p;
            }
        }

        public bool IsValidRange() =>
            StartPort > 0 &&
            EndPort > 0 &&
            EndPort >= StartPort &&
            EndPort <= 65535;
    }
}
