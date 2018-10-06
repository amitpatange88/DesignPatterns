using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder.IBuilder
{
    public interface ISystemBuilder
    {
        void AddMemory(string memory);

        void AddDrive(string size);

        ComputerSystemProduct GetSystem();
    }
}
