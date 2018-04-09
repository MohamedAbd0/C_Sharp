using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
   
    struct Student : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student( int _id ,string _name):this()
        {
            Id = _id;
            Name = _name;
        }

        public int CompareTo(object obj)
        {
            return Id.CompareTo(((Student)obj).Id);
        }

        public override string ToString()
        {
                return string.Format(@"Student ID : {0}  , Student Name : {1} ",Id,Name);
        }
    }

    struct Track : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student []  Students { get; set; }

        public Track( int _id ,String _name ,Student [] _Students):this()
        {
            Id = _id;
            Name = _name;
            Students = _Students;

        }

        public int CompareTo(object obj)
        {
            return Id.CompareTo(((Track)obj).Id);
        }
        public override string ToString()
        {
            Console.WriteLine(@"Track ID : {0}  , Track Name : {1} ", Id, Name);
            foreach (Student item in Students)
            {
                Console.WriteLine(item);
            }
            return "";

        }
        public string this[int x]
        {
            set
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Id == x)
                        Students[i].Name = value;
                }
            }
            get
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Id == x)
                        return Students[i].Name;
                }
                return "Not Found";
            }

        }
        public int this[string n]
        {
            set
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Name == n)
                        Students[i].Id = value;
                }
            }
            get
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Name == n)
                        return Students[i].Id;
                }
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] Stu_Dot_Net = new Student[] { new Student(1,"Mohamed Abdo"),
            new Student (2,"Ahmed atif"),
            new Student (3,"Mohamed Ali"),
            new Student (11,"Eman Ashraf"),
            new Student (6,"Asmaa Mohamed"),
            new Student (4,"Amr Nour")
            };
            Student[] Stu_OS = new Student[] { new Student(5,"Amr Abdo"),
            new Student (2,"Ashar atif"),
            new Student (4,"Mohamed Ali"),
            new Student (8,"Mohamed Ashraf"),
            new Student (6,"Mona Mohamed"),
            new Student (3,"Amr Bakr")
            };

            Track Dot_Net = new Track(3, " Dot Net ", Stu_Dot_Net);
            Track OS = new Track(2, " OS ", Stu_OS);

            Console.WriteLine(Dot_Net[3]);
            Dot_Net[3] = "Gada Amr ";
            Console.WriteLine(Dot_Net[3]);
            Console.WriteLine(OS[6]);
            OS[6] = "Mohamed Naser ";
            Console.WriteLine(OS[6]);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(OS["Amr Bakr"]);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" Before Sort ");
            Console.WriteLine(OS.ToString());
            Console.WriteLine(" After Sort ");
            Array.Sort(Stu_OS);
            Console.WriteLine(OS);
            Console.WriteLine(" Before Sort ");
            Console.WriteLine(Dot_Net);
            Console.WriteLine(" After Sort ");
            Array.Sort(Stu_Dot_Net);
            Console.WriteLine(Dot_Net);

            Console.ReadKey();
        }
    }
}
