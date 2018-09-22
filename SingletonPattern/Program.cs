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
            Singleton s1 = new Singleton();
            s1.PrintDetails("Customer");

            Singleton s2 = new Singleton();
            s2.PrintDetails("Employee");

            Console.ReadLine();


        }
    }
}
