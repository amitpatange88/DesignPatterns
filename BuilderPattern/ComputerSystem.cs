using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ComputerSystem
    {
        private string _RAM;
        private string _HDDSize;

        public ComputerSystem()
        {

        }

        public ComputerSystem(string RAM, string HDD)
        {
            _RAM = RAM;
            _HDDSize = HDD;
        }

        public string GetSystem()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("RAM: {0}", _RAM));
            sb.Append(string.Format("HDDSize: {0}", _HDDSize));

            return sb.ToString();
        }
    }
}
