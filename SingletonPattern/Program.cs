using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multithreading voiltes the principle of Singleton pattern so lock the object
            Parallel.Invoke(
                ()=> PrintCustomer(),
                ()=> PrintEmployee()
                );
        
            Console.ReadLine();
        }

        private static void PrintEmployee()
        {
            Singleton s2 = Singleton.Instance;
            s2.PrintDetails("Employee");
        }

        private static void PrintCustomer()
        {
            Singleton s1 = Singleton.Instance;
            s1.PrintDetails("Customer");
        }
    }
}
