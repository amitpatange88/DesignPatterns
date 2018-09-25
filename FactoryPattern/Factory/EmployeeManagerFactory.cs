using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    class EmployeeManagerFactory
    {
        public EmployeeManagerFactory()
        {

        }

        public IEmployeeManager GetEmployeeTypeObject(int EmpType)
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
