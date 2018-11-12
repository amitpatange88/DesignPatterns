using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ExitExecute : IExecute
    {
        public ExitExecute() 
        {
            strCommand = "Exit";
        }

        public override void CmdExecute()
        {
            Console.WriteLine("Exit");
        }
    }
}
