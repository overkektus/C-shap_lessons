using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    delegate void PushPrinterButton(); //Объявление делегата
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            // подписка на событие с указанием конкретного метода
            mouse.Click += new PushPrinterButton(mouse.OnMouseClick);
            //.......................
            mouse.DoEvent(); // вызывается событие
        }
    }

    class Mouse
    {
        public event PushPrinterButton Click; // объявление события о нажатии кнопки мыши
        public void DoEvent() // генерация события
        {
            if (Click != null)
                Click(); // запуск события
        }
        public void OnMouseClick()
        {
            Console.WriteLine("Произошло нажатие кнопки мыши по кнопке печати.\n");
            Console.ReadLine();
        }
    }
}
