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
        ComputerSystemProduct desktop = new ComputerSystemProduct();
        public void AddDrive(string size)
        {
            desktop.HDDSize = size;
        }

        public void AddMemory(string memory)
        {
            desktop.RAM = memory;
        }

        public void AddKeyBoard(string type)
        {
            desktop.KeyBoard = type;
        }

        public void AddMouse(string mouse)
        {
            desktop.Mouse = mouse;
        }

        public void AddTouchScreen(string enabled)
        {
            return;
        }

        public ComputerSystemProduct GetSystem()
        {
            return desktop;
        }

        public void AddProcessor(string ptype)
        {
            desktop.Processor = ptype;
        }
    }
}
