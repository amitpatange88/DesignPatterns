using BuilderPattern.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder.ConcreteBuilder
{
    class DesktopBuilder : ISystemBuilder
    {
        public void AddDrive(string size)
        {
            throw new NotImplementedException();
        }

        public void AddMemory(string memory)
        {
            throw new NotImplementedException();
        }

        public ComputerSystemProduct GetSystem()
        {
            throw new NotImplementedException();
        }
    }
}
