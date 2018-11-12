using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class PrintExecute : IExecute
    {
        public PrintExecute() 
        {
            strCommand = "Print";
        }

        public override void CmdExecute()
        {
            Console.WriteLine("Print");
        }
    }
}
