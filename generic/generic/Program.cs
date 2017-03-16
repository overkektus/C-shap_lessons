using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> mass = new List<byte>(); //обобщенный список для работы с типом byte
            mass.Add(100);

            byte x = mass[0];

            List<SomeClass> massUser = new List<SomeClass>();

            List<int> mass2 = new List<int>();
            mass2.Add(1);
            mass2.Add(5);
            mass2.Add(12);

            for (int i = 0; i < mass2.Count; i++)
                Console.WriteLine(mass2[i]);

            massUser.Add(new SomeClass(1));
            massUser.Add(new SomeClass(5));
            massUser.Add(new SomeClass(12));

            for (int j = 0; j < massUser.Count; j++)
                Console.WriteLine(massUser[j].x);
        }
    }
}

class SomeClass
{
    public int x;
    public SomeClass(int input)
    {
        x = input;
    }
}
