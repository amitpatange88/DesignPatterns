using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private int _count = 0;
        private static Singleton instance = null;
        private static readonly object obj = new object();

        public static Singleton Instance
        {
            get
            {
                //Double verification for instance outside and inside lock object.
                //See : https://en.wikipedia.org/wiki/Double-checked_locking
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            return new Singleton();
                    }
                }

                return instance;
            }
        }

        private Singleton()
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
