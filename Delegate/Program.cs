using System;

namespace Delegate
{
    public delegate void ShowTypeInfo(Student student);
    class Program
    {
        static void Main(string[] args)
        {
            // ShowTypeInfo showText = ShowStudentInfoText;
            // ShowTypeInfo showHTML = ShowStudentInfoHTML;

            //Action<kiểu_tham_số_1, kiểu_tham_số_2, ... > var_delegate;
            // Action<Student> action = (Student student) =>
            // {
            //     Console.WriteLine($"{student.ID}-{student.Name}");
            // };

            //Func<kiểu_tham_số_1, kiểu_tham_số_2, ..., kiểu_trả_về> var_delegate;

            Student student = new Student(1, "hung");
            ShowTypeInfo showText = new ShowTypeInfo(ShowStudentInfoText);
            ShowTypeInfo showHTML = new ShowTypeInfo(ShowStudentInfoHTML);
            ShowTypeInfo sum = showText + showHTML;
            student.GetStudentInfo(sum);
        }

        public static void ShowStudentInfoText(Student student)
        {
            Console.WriteLine($"ID:{student.ID} - Name:{student.Name}");
        }

        public static void ShowStudentInfoHTML(Student student)
        {
            Console.WriteLine($"<span>{student.ID} - {student.Name}<span>");
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public void GetStudentInfo(ShowTypeInfo showTypeInfo)
        {
            Console.WriteLine("Get student info");
            showTypeInfo(this);
        }
    }


}
