using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //without using builder design pattern call.
            //here we have one problem if in future requirement is changed to add
            //one more ComputerSystem configuration type like Mouse/touch pad and keyboard then 
            //we then need to update construtor param which is bad for changes. So we use builder pattern.
            ComputerSystem cs = new ComputerSystem("8GB", "1TB");
            string systemConfig = cs.GetSystem();

            //So we implement builder pattern here. Start Builer design pattern implementation.




        }
    }
}
