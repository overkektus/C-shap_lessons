using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate string Del(int x, bool y);
    delegate void DelStat(ref int x);
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass SC = new SomeClass();
            Del del = new Del(SC.Method);
            //
            //
            //
            string s = del(10, true);
            Console.WriteLine(s);
            Console.ReadKey();

            DelStat delStat = new DelStat(SomeClass.MethodStat);
            int p = 50;
            delStat(ref p);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}

class SomeClass
{
    public string Method(int x, bool flag)
    {
        return string.Format(x.ToString() + " " + flag.ToString());
    }

    public static void MethodStat(ref int x)
    {
        x *= x;
    }
}
