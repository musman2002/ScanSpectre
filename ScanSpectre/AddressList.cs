using System.Collections.Generic;

namespace ScanSpectre
{
    public class AddressList
    {
        public int StartPort { get; }
        public int EndPort { get; }

        public AddressList(int start, int end)
        {
            StartPort = start;
            EndPort = end;
        }

        public IEnumerable<int> Ports()
        {
            for (int p = StartPort; p <= EndPort; p++)
                yield return p;
        }
    }
}
