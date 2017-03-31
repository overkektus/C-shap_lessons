using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events2
{
    delegate void ChangeStatus(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Corvet firstCar = new Corvet();
            firstCar.ChangePrice += new ChangeStatus(FirstCar_ChangePrice);
            Console.WriteLine("Задайте новую цену на автомобиль: ");
            firstCar.Price = Int32.Parse(Console.ReadLine());
        }

        private static void FirstCar_ChangePrice(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Corvet
    {
        int price;

        public event ChangeStatus ChangePrice;

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                if (ChangePrice != null)
                    ChangePrice("Цена изменена на: " + this.price);
            }
        }
    }
}
