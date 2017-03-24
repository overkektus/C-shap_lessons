using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator_IEnumerable
{
    class MyInt : IEnumerable, IEnumerator
    {
        int[] ints = { 12, 13, 1, 4 };
        int index = -1;

        // Реализуем интерфейс IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // Реализуем интерфейс IEnumerator
        public bool MoveNext()
        {
            if (index == ints.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return ints[index];
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyInt mi = new MyInt();

            foreach (int i in mi)
                Console.Write(i + "\t");

            Console.ReadLine();
        }
    }
}
