using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class FileExecute : IExecute
    {
        public FileExecute() 
        {
            strCommand = "File";
        }

        public override void CmdExecute()
        {
            Console.WriteLine("File");
        }
    }
}
