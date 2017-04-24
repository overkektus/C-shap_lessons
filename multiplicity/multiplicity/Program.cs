using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression progression = new Progression(100);

            foreach (int i in progression)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(progression.Count());
            Console.ReadLine();
        }
    }
    
    public class Progression : IEnumerable<int>
    {
        private readonly int _itemCount;

        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            int current = 1;
            for (int i = 0; i < _itemCount - 1; i++)
            {
                if (i == 0) yield return 1;

                current += 3;
                yield return current;
            }
            
            //return new ProgressionIterator(_itemCount);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        private int _position;
        private int _current;

        public ProgressionIterator(int ItemCount)
        {
            _itemCount = ItemCount;
            _current = 1;
            _position = 0;
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (_position > 0)
                _current += 3;
            if(_position < _itemCount)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _position = 0;
            _current = 1;
        }

        public int Current
        {
            get { return _current; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }

    public class StoreCollection : ICollection<int>
    {
        private readonly string _filePath;

        public StoreCollection(string filePath)
        {
            _filePath = filePath;
        }

        private string[] GetNumbers()
        {
            string line = File.ReadAllText(_filePath);
            string[] numbers = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            string[] numbers = GetNumbers();
            foreach (string number in numbers)
            {
                yield return Int32.Parse(number);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

        }

        public void Add(int item)
        {
            string[] numbers = GetNumbers();

            if (numbers.Length == 0)
                File.WriteAllText(_filePath, item.ToString());
            else
                File.AppendAllText(_filePath, "," + item.ToString());
        }

        public void Clear()
        {
            File.WriteAllText(_filePath, "");
        }

        public bool Remove(int item)
        {
            string[] numbers = GetNumbers():
            string line = File.ReadAllText(_filePath);

            int symbolPosition = 0;

            foreach(string number in numbers)
            {
                if(Int32.Parse(number) == item)
                {
                    if(numbers.Length == 1)
                    {
                        line = "";
                    }
                    else if (symbolPosition == 0)
                    {
                        line = line.Substring(symbolPosition + number.Length + 1);
                    }
                    else
                    {
                        line = line.Remove(symbolPosition - 1, number.Length +  1);
                    }
                }
            }
        }
        
        public bool Contains(int item)
        {

        }

        public void CopyTo()
        {

        }
    }
}
