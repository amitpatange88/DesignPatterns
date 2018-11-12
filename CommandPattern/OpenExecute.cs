using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class OpenExecute : IExecute
    {
        public OpenExecute() 
        {
            strCommand = "Open";
        }

        public override void CmdExecute()
        {
            Console.WriteLine("Open");
        }
    }
}
