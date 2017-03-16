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
            Method(5, 10);
            Method("afsgsg", "fshfd");
        }

        static T Method<T>(T x, T y)
        {
            Console.WriteLine("Первый параметр x = {0}, второй параметр y = {1}", x,y);
            Console.ReadLine();
            return x;
        }
    }
}
