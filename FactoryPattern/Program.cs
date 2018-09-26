using FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code without using Factory Design Pattern
            WithoutUsingFactoryPattern(1);

            //Apply Simple factory pattern without RIP pattern..
            SimpleFactoryPattern_WithoutUsing_RIP_Pattern(2);

            //Apply Simple factory pattern without RIP pattern..
            SimpleFactoryPattern_WithUsing_RIP_Pattern(3);
        }



        private static void SimpleFactoryPattern_WithoutUsing_RIP_Pattern(int EmpType)
        {
            //In this case we achieved de-coupling. We actually do polymorphisim. Poly achieves decoupling.
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            IEmployeeManager emp = empFactory.GetEmployeeTypeObject_WithoutUsing_RIP_Pattern(EmpType);
            decimal Pay = emp.GetPay();
            decimal Bonus = emp.GetBonus();
        }


        private static void SimpleFactoryPattern_WithUsing_RIP_Pattern(int EmpType)
        {
            //In this case we achieved de-coupling. We actually do polymorphisim. Poly achieves decoupling.
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            IEmployeeManager emp = empFactory.GetEmployeeTypeObject_WithUsing_RIP_Pattern(EmpType);
            decimal Pay = emp.GetPay();
            decimal Bonus = emp.GetBonus();
        }

        private static void WithoutUsingFactoryPattern(int EmpType)
        {
            //Code without using Factory Design Pattern

            if (EmpType == 1)
            {
                PermanantEmployee emp = new PermanantEmployee();
                emp.Pay = 10;
                emp.Bonus = 8;
            }
            else if (EmpType == 2)
            {
                TemporaryEmployee emp = new TemporaryEmployee();
                emp.Pay = 12;
                emp.Bonus = 6;
            }
            else if (EmpType == 3)
            {
                ContractualEmployee emp = new ContractualEmployee();
                emp.Pay = 8;
                emp.Bonus = 4;
            }

            //perform operation on emp object.
        }
    }
}
