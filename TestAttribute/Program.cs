using System;
using System.Reflection;
using System.Text;
namespace TestAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            Student student = new Student
            {
                ID = 10,
                Name = "hung ngo"
            };
            // su dung reflection
            Type info = student.GetType();
            var res = info.GetProperties();
            foreach (PropertyInfo property in res)
            {
                string property_name = property.Name;
                object property_value = property.GetValue(student);
                Console.WriteLine($"Thuộc tính {property_name} giá trị là {property_value}");
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
