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
    class Asynchronous
    {
        public static void Run()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var add = Add(4, 5);
            var division = Division(8, 2);
            var subtraction = Subtraction(9, 4);
            var multiply = Multiply(add.Result, division.Result, subtraction.Result);

            Task.WaitAll(multiply);
            Console.WriteLine($"ket qua: {multiply.Result}");
            Console.WriteLine("-----ket thuc");

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();

        }
        static async Task<int> Add(int a, int b)
        {
            Func<Object, int> myFunc = (Object obj) =>
                 {
                     dynamic o = obj;
                     Thread.Sleep(4000);
                     Console.WriteLine("------add xong");
                     return o.x + o.y;
                 };

            Task<int> add = new Task<int>(myFunc, new { x = a, y = b });
            add.Start();
            var res = await add;
            Console.WriteLine($"add: {add.Result}");
            return res;
        }
        //multiply

        static async Task<int> Multiply(int resAdd, int resDivision, int resSubtraction)
        {

            Func<Object, int> myFunc = (Object obj) =>
               {
                   dynamic o = obj;
                   Thread.Sleep(6000);
                   Console.WriteLine("------multiply xong");
                   return o.x * o.y * o.z;
               };

            Task<int> multiply = new Task<int>(myFunc, new { x = resAdd, y = resDivision, z = resSubtraction });
            multiply.Start();
            var res = await multiply;
            //Console.WriteLine($"multiply: {multiply.Result}");
            return res;
        }
        //division
        static async Task<int> Division(int c, int d)
        {
            Func<Object, int> myFunc = (Object obj) =>
                           {
                               dynamic o = obj;
                               Thread.Sleep(5000);
                               Console.WriteLine("------division xong");
                               return o.x / o.y;
                           };

            Task<int> division = new Task<int>(myFunc, new { x = c, y = d });
            division.Start();
            var res = await division;
            Console.WriteLine($"division: {division.Result}");
            return res;
        }
        //Subtraction
        static async Task<int> Subtraction(int e, int f)
        {
            Func<Object, int> myFunc = (Object obj) =>
               {
                   dynamic o = obj;
                   Thread.Sleep(3000);
                   Console.WriteLine("------subtraction xong");
                   return o.x - o.y;
               };

            Task<int> subtraction = new Task<int>(myFunc, new { x = e, y = f });
            subtraction.Start();
            var res = await subtraction;
            Console.WriteLine($"subtraction: {subtraction.Result}");
            return res;
        }
    }
}
