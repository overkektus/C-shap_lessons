using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // Создадим обобщенный класс имеющий параметр типа T
    class MyObj<T>
    {
        T obj;

        public MyObj(T obj)
        {
            this.obj = obj;
        }

        public void objectType()
        {
            Console.WriteLine("Тип объекта: " + typeof(T));
        }
    }

    // Обобщенный класс с несколькими параметрами
    class MyObjects<T, V, E>
    {
        T obj1;
        V obj2;
        E obj3;

        public MyObjects(T obj1, V obj2, E obj3)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
            this.obj3 = obj3;
        }

        public void objectsType()
        {
            Console.WriteLine("\nТип объекта 1: " + typeof(T) +
                              "\nТип объекта 2: " + typeof(V) +
                              "\nТип объекта 3: " + typeof(E));
        }
    }

    class Program
    {
        static void Main()
        {
            // Создадим экземпляр обобщенного класса типа int
            MyObj<int> obj1 = new MyObj<int>(25);
            obj1.objectType();

            MyObjects<string, byte, decimal> obj2 = new MyObjects<string, byte, decimal>("Alex", 26, 12.333m);
            obj2.objectsType();

            Console.ReadLine();
        }
    }
}
