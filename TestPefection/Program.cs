using System;

namespace TestPefection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("reflection trong c#");
            Console.WriteLine("------------------------------------");
            Rectangle rectangle = new Rectangle(4.5, 7.5);
            rectangle.Display();
            Type type = rectangle.GetType();
            //loc qua attributes cua lop
            // foreach (var item in type.GetCustomAttributes(true))
            // {
            //     DeBugInfo dbi = (DeBugInfo)item;
            //     if (null != dbi)
            //     {
            //         Console.WriteLine("Bug no: {0}", dbi.BugNo);
            //         Console.WriteLine("Developer: {0}", dbi.Developer);
            //         Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
            //         Console.WriteLine("Remarks: {0}", dbi.Message);
            //     }
            // }
            //loc qua arrtibutes cua method
            foreach (var method in type.GetMethods())
            {
                foreach (var item in method.GetCustomAttributes(false))
                {
                    try
                    {
                        DeBugInfo dbi = item as DeBugInfo;
                        if (null != dbi)
                        {
                            Console.WriteLine("Bug no: {0}", dbi.BugNo);
                            Console.WriteLine("Developer: {0}", dbi.Developer);
                            Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                            Console.WriteLine("Remarks: {0}", dbi.Message);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }


}
