using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanSpectre
{
    public class AddressList
    {
        public int Start { get; }
        public int Stop { get; }

        public AddressList(int start, int stop)
        {
            Start = start;
            Stop = stop;
        }
    }
}
