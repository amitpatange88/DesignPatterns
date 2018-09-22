using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Eager loading singleton class
    /// </summary>
    public sealed class SingletonEager
    {
        private int _count = 0;
        private static readonly SingletonEager instance = new SingletonEager(); //Assigning objects here only immplies Eager loading.

        public static SingletonEager Instance
        {
            get
            {
                return instance;
            }
        }

        private SingletonEager()
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
