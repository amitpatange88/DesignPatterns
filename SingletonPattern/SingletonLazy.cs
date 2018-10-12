using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Lazy loading singleton class. .NET 4.0 after.
    /// </summary>
    public sealed class SingletonLazy
    {
        private int _count = 0;
        
        //Lazy loading is a thread safe. It automatically lock the object.
        private static readonly Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(()=> new SingletonLazy()); 
        //Assigning objects here only immplies lazy loading.

        public static SingletonLazy Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private SingletonLazy()
        {
            ++_count;
            Console.WriteLine("SingletonLazy object creation :" + _count);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
