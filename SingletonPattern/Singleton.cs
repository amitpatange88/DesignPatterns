using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private int _count = 0;

        public Singleton()
        {
            ++_count;
            Console.WriteLine("Singleton object creation :"+_count);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
