using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispose_finalize
{
    // Данный класс реализует интерейс IDisposable
    class FinalizeObject : IDisposable
    {
        public int id { get; set; }

        public FinalizeObject(int id)
        {
            this.id = id;
        }

        // Реализуем метод Dispose()
        public void Dispose()
        {
            Console.WriteLine("Высвобождение объекта!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FinalizeObject obj = new FinalizeObject(4);
            obj.Dispose();

            Console.Read();
        }
    }
}
