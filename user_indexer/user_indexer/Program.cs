using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abiturients =
            {
                "Ivanov",
                "Petrov",
                "Sidorov",
                "Petrenko",
                "Babenko",
                "Vilenko",
                "Kosoj",
                "Bosoj",
                "Nemoj",
                "Gudok"
            };

            Journal journ = new Journal();

            for (int i = 0; i < abiturients.Length; i++)
                journ[i] = new Student(i + 1, abiturients[i]);

            foreach(Student st in journ)
                Console.WriteLine(st.Number + " -> " + st.Name);
        }
    }

    class Student
    {
        int number;
        string name;

        public Student(int number, string name)
        {
            this.number = number;
            this.name = name;
        }

        public int Number
        {
            get { return number; }
            set
            {
                if (value > 0 && value < 31)
                    number = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 0 && value.Length < 51)
                name = value;
            }
        }
    }

    class Journal
    {
        ArrayList journal = new ArrayList();

        public Student this[int index]
        {
            get { return (Student)journal[index]; }
            set
            {
                if (index > -1 && (value is Student))
                    journal.Add(value);
            }
        }

        public int Length
        {
            get { return journal.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object o in journal)
                yield return o;
        }
    }
}
