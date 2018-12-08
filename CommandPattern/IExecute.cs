using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class IExecute
    {
        public string strCommand = string.Empty;

        public static string test = string.Empty;
        
        static IExecute()
        {

        }

        public virtual void CmdExecute()
        {

        }
       
    }
}
