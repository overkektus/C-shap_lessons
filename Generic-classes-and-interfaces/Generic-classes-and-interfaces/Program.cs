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

        }
    }
}

class SomeClass : IsomeInterface<string>
{
    public string SomeMethod(string input1, string input2)
    {
        return input1 + " " + input2;
    }
    public void ShowData(string input)
     {
        Console.WriteLine(input.ToUpper());
     }
}

public interface IsomeInterface<T>
{
    T SomeMethod(T input1, T input2);
    void ShowData(T input);
}


class SomeAnyClass : IsomeInterface<int>
{
    public int SomeMethod(int input1, int input2)
    {
        return input1 + input2 - 3;
    }

    public void ShowData(int input)
    {
        Console.WriteLine(input.ToString());
    }
}