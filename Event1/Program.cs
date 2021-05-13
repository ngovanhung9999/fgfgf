using System;

namespace Event1
{
    public delegate void UpdateName(string name);
    class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student();
            student.ChangedName += changed;
            student.Name = "thang";

            student.Name = "hung";

        }

        public static void changed(string name)
        {
            Console.WriteLine($"Ten da thay doi:{name}");
        }
    }

    public class Student
    {


        public event UpdateName ChangedName;
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                if (ChangedName != null)
                {
                    ChangedName(value);
                }
            }
        }
    }

}
