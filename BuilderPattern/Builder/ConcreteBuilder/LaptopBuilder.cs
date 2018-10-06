using BuilderPattern.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder.ConcreteBuilder
{
    class LaptopBuilder : ISystemBuilder
    {
        ComputerSystemProduct laptop = new ComputerSystemProduct();
        public void AddDrive(string size)
        {
            laptop.HDDSize = size;
        }

        public void AddMemory(string memory)
        {
            laptop.RAM = memory;
        }

        public ComputerSystemProduct GetSystem()
        {
            return laptop;
        }
    }
}
