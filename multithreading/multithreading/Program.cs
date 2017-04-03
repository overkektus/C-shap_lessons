using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass sc = new SomeClass();

            Thread thread = new Thread(sc.JustMethod);
            thread.Start();

            sc.JustMethod();
            Console.Read();
        }
    }
}


class SomeClass
{
    bool flag = false;

    public void JustMethod()
    {
        Console.WriteLine("flag = {0}", flag);
        flag = !flag;
    }
}