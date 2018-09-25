using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class TemporaryEmployee : IEmployeeManager
    {
        public decimal Pay;
        public decimal Bonus;

        public TemporaryEmployee()
        {

        }

        public decimal GetBonus()
        {
            return 8;
        }

        public decimal GetPay()
        {
            return 12;
        }

        //add methods here.
    }
}
