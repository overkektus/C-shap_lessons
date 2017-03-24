using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_classes_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass<int> SC1 = new SomeClass<int>();
            SC1.ShowData();

            SomeClass<string> SC2 = new SomeClass<string>();
            SC2.ShowData();

            SomeClass<int> SC11 = new SomeClass<int>(10, 20);
            SC11.ShowData();

            SomeClass<string> SC22 = new SomeClass<string>("Hello", "!!!");
            SC22.ShowData();
        }
    }
}

class SomeClass<T>
{
    T first;
    public T First
    {
        get { return first; }
        set { first = value; }
    }

    T second;
    public T Second
    {
        get { return second; }
        set { second = value; }
    }

    public SomeClass(T input1, T input2)
    {
        first = input1;
        second = input2;
    }

    public SomeClass()
    {
        first = default(T);
        second = default(T);
    }

    public void ShowData()
    {
        Console.WriteLine("First = {0}, Second = {1}", First, Second);
        Console.ReadKey();
    }
}