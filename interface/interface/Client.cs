using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Client : IAccount
{
        int _sum; // переменная для хранения суммы
        int _percentage; // переменная для хранения процента

        public string Name { get; set; }
        public Client(string name, int sum, int percentage)
        {
            Name = name;
            _sum = sum;
            _percentage = percentage;
        }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
            }
        }

        public int Percentage
        {
            get { return _percentage; }
        }

        public void Display()
        {
            Console.WriteLine("Клиент " + Name + " имеет счет на сумму " + _sum);
        }
}
}
