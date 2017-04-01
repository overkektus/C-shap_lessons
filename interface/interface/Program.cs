using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Tom", 200, 10);
            client.Put(30);
            client.Display();
            client.Withdraw(100);
            client.Display();

            IAccount client2 = new Client("James", 400, 12);
            client2.Put(50);
            ((Client)client2).Display();
        }
    }
}
