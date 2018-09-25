using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class PermanantEmployee : IEmployeeManager
    {
        public decimal Pay;
        public decimal Bonus;

        public PermanantEmployee()
        {

        }

        public decimal GetPay()
        {
            return 10;
        }

        public decimal GetBonus()
        {
            return 8;
        }

        //add methods here.
    }
}
