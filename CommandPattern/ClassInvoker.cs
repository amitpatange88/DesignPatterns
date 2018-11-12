using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ClassInvoker
    {
        private static ArrayList _objList = new ArrayList();

        public ClassInvoker()
        {
            _objList.Add(new FileExecute());
            _objList.Add(new OpenExecute());
            _objList.Add(new PrintExecute());
            _objList.Add(new ExitExecute());
        }

        public IExecute CheckUsingCommandDesignPattern(string strCmd)
        {
            IExecute cmdObj = null;
            foreach (IExecute obj in _objList)
            {
                if(obj.strCommand == strCmd)
                {
                    cmdObj = obj;
                    break;
                }
            }

            return cmdObj;
        }
    }
}
