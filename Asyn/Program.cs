using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
namespace Asyn
{
    //(a+b)*c/d*(e-f)

    //  add         (a+b) 4s
    //  division     c/d  5s
    //  subtraction (e-f) 3s
    // add*subtraction*division 6s
    // tong 18s
    class Program
    {
        static void Main(string[] args)
        {
            Asynchronous.Run();
            //Synchronous.Run();
        }
    }
}
