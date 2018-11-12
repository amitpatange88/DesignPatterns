using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassInvoker inv = new ClassInvoker();
            IExecute exeObj = inv.CheckUsingCommandDesignPattern("Print");
            exeObj.CmdExecute();

            Console.ReadKey();
        }

        /// <summary>
        /// Use Case : This is where we can use command design pattern.
        /// </summary>
        /// <param name="strAction"></param>
        private void Check(string strAction)
        {
            if(strAction == "File")
            {
                //handle action for file command
            }
            else if (strAction == "Open")
            {
                //handle action for Open command
            }
            else if (strAction == "Print")
            {
                //handle action for Print command
            }
            else if (strAction == "Exit")
            {
                //handle action for Exit command
            }
        }
    }
}
