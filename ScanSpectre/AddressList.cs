using System;
using System.Collections.Generic;

namespace ScanSpectre
{
    public class AddressList
    {
        public int Start { get; }
        public int Stop { get; }
        private List<int> portList;

        public AddressList(int start, int stop)
        {
            if (start > stop)
                throw new ArgumentException("Start port must be less than or equal to the stop port.");

            Start = start;
            Stop = stop;
            portList = GeneratePortList();
        }

        // Generates a list of ports in the range specified by Start and Stop
        private List<int> GeneratePortList()
        {
            var list = new List<int>();
            for (int i = Start; i <= Stop; i++)
            {
                list.Add(i);
            }
            return list;
        }

        // Returns the generated list of ports
        public List<int> GetPortList()
        {
            return portList;
        }

        // Allows custom filtering of the port list
        public List<int> GetFilteredPortList(Predicate<int> filter)
        {
            return portList.FindAll(filter);
        }
    }
}
