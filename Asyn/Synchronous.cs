using System;
using System.Threading;
using System.Threading.Tasks;
namespace Asyn
{
    //(a+b)*c/d*(e-f)

    //  add         (a+b) 4s
    //  division     c/d  5s
    //  subtraction (e-f) 3s
    // add*subtraction*division 6s
    class Synchronous
    {
        public static void Run()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            int add = Add(4, 5);
            int division = Division(8, 2);
            int subtraction = Subtraction(9, 4);
            int multiply = Multiply(add, division, subtraction);
            Console.WriteLine($"ket qua: {multiply}");
            Console.WriteLine("-----ket thuc");

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();

        }
        static int Add(int a, int b)
        {
            int res = a + b;
            Thread.Sleep(4000);
            Console.WriteLine("------add xong");
            Console.WriteLine($"add: {res}");
            return res;
        }
        //multiply

        static int Multiply(int resAdd, int resDivision, int resSubtraction)
        {
            int res = resAdd * resDivision * resSubtraction;
            Thread.Sleep(6000);
            Console.WriteLine("------multiply xong");
            return res;
        }
        //division
        static int Division(int c, int d)
        {
            int res = c / d;
            Thread.Sleep(5000);
            Console.WriteLine("------division xong");
            Console.WriteLine($"division: {res}");
            return res;
        }
        //Subtraction
        static int Subtraction(int e, int f)
        {
            int res = e - f;
            Thread.Sleep(3000);
            Console.WriteLine("------subtraction xong");
            Console.WriteLine($"subtraction: {res}");
            return res;
        }
    }
}
