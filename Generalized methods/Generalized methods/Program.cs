using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalized_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass SC = new SomeClass();

            SC.Method<int>();
            SC.Method<string>();
        }

class SomeClass
        {
            public void Method<T>()
            {
                Console.WriteLine(typeof(T).Name);
                Console.ReadLine();
                return;
            }
        }
    }
}
