using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group_delegate
{
    delegate void Del();
    class Program
    {
        static void Main(string[] args)
        {
            Del del = new Del(M1);
            del += M2;
            del += M1;
            del -= M2;
            MDel(ref del);
        }
        static void M1()
        {
            Console.WriteLine("Это метод M1");
            Console.ReadLine();
        }
        static void M2()
        {
            Console.WriteLine("Этот метод M2");
            Console.ReadLine();
        }
        static void MDel(ref Del d)
        {
            Console.WriteLine("Передача делегата в качестве параметра");
            d();
        }
    }
}
