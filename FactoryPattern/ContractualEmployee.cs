using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ContractualEmployee : IEmployeeManager
    {
        public decimal Pay;
        public decimal Bonus;

        public ContractualEmployee()
        {

        }

        public decimal GetBonus()
        {
            return 4;
        }

        public decimal GetPay()
        {
            return 8;
        }

        //add methods here
    }
}
