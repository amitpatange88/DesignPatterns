using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ReopenExecute : IExecute
    {
        public ReopenExecute() 
        {
            strCommand = "Reopen";
        }

        public override void CmdExecute()
        {
            Console.WriteLine("Reopen");
        }
    }
}
