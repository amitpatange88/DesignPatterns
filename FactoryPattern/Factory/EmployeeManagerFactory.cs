using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    class EmployeeManagerFactory
    {
        //If we want to remove this if condition.
        private Dictionary<int, IEmployeeManager> EmpDict = new Dictionary<int, IEmployeeManager>();
        public EmployeeManagerFactory()
        {
            //Design Pattern - Lazy Loading pattern.
            if(EmpDict.Count == 0)
            {
                EmpDict.Add(1, new PermanantEmployee());
                EmpDict.Add(2, new TemporaryEmployee());
                EmpDict.Add(3, new ContractualEmployee());
            }
        }

        /// <summary>
        /// RIP pattern : Replace If with Polymorphisim
        /// </summary>
        /// <param name="EmpType"></param>
        /// <returns></returns>
        public IEmployeeManager GetEmployeeTypeObject(int EmpType)
        {
            //RIP pattern : Replace If with Polymorphisim.
            return EmpDict[EmpType];
        }


        /// <summary>
        /// Helps to keep centraalized object creation. This is object creation with If statement. If same copy of other function we have removed
        /// If condition by introducing dictionary.
        /// </summary>
        /// <param name="EmpType"></param>
        /// <returns></returns>
        public IEmployeeManager GetEmployeeTypeObject_SameCopy(int EmpType)
        {
            IEmployeeManager Emp = null;
            if (EmpType == 1)
            {
               Emp = new PermanantEmployee();
            }
            else if (EmpType == 2)
            {
               Emp = new TemporaryEmployee();
            }
            else if (EmpType == 3)
            {
               Emp = new ContractualEmployee();
            }

            return Emp; 
        }
    }
}
