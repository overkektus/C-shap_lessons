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
            Work<SomeClass1> w = new Work<SomeClass1>(new SomeClass1("Имя для класса1"));
            w.ShowData();
        }
    }
}

class BaseClass
{
    public string name;
}

class SomeClass1 : BaseClass
{
    public SomeClass1(string input)
    {
        name = input;
    }
}

class Work<T> where T: BaseClass
{
    public T someField;

    public Work(T input)
    {
        someField = input;
    }

    public void ShowData()
    {
        Console.WriteLine(someField.name);
        Console.ReadKey();
    }
}

class SomeClass2 : BaseClass
{
    public SomeClass2(string input)
    {
        name = input;
    }
}
