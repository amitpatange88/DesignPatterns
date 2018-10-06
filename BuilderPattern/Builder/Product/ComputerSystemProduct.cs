using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ComputerSystemProduct
    {
        public string RAM { get; set; }
        public string HDDSize { get; set; }

        public ComputerSystemProduct()
        {
        }

        public string GetSystem()
        {
            string system = string.Format("RAM {0}  and HDD {1}", RAM, HDDSize);

            return system;
        }
    }
}
