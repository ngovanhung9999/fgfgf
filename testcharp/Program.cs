using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace testcharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach ( String item in Program.ParseArray(new object[] { 1, 2, "a", "b" }))
            // {
            //     Console.WriteLine(item);

            // }

            // int argNumber=1;
            // string argMessage="h", argDefault="h";
            // Method(out argNumber, out argMessage, out argDefault);
            // Console.WriteLine(argNumber);
            // Console.WriteLine(argMessage);
            // Console.WriteLine(argDefault==null);

            // foreach ( double item in Program.FindLargest(new double[][]{new double[]{4,2,7,1},new double[]{20,70,40,90},new double[]{1,2,0}}))
            // {
            //     Console.WriteLine(item);

            // }

            // foreach (int item in Program.ArrayOfMultiples(5, 7))
            // {
            //     Console.WriteLine(item);

            // }

            //Console.WriteLine(Program.ReversCase("ngo Hung vAn"));

            //Console.WriteLine(Program.Bomd("hung ngo boMd"));

            // foreach (int item in Program.CountPossSumNeg(new double[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 }))
            // {
            //     Console.WriteLine(item);

            // }

            //Console.WriteLine(Program.GetMiddle("testoing"));
            //Console.WriteLine(Program.checkEquality(1,1));
            //Console.WriteLine(Program.Maskify("64607935616"));
            Console.WriteLine(Program.ValidatePIN("!23456"));
        }

        public static bool ValidatePIN(string pin){
            if(pin.Length==4||pin.Length==6){
                try{
                   Int32.Parse(pin);
                   return true;
                }catch{
                    return false;
                }
            }
            return false;
        }

        public static string Maskify(string str){
            int len=str.Length;
            if(len<=4){
                return str;
            }
            return string.Concat(Enumerable.Repeat("#",len-4))+str.Substring(len-4);
        }
        public static bool checkEquality(Object a, Object b)
        {
            return a.Equals(b);
        }
        public static string GetMiddle(string str)
        {
            //xuat ra 2 hoac 1 ky tu o giua
            int middle = str.Length / 2;
            return str.Length % 2 != 0 ? $"{str[middle]}" : $"{str[middle - 1]}{str[middle]}";
        }

        public static string GetMiddle1(string str)
        {
            int i = 1 - str.Length % 2;
            return str.Substring(str.Length / 2 - i, 1 + i);
        }
        public static string[] ParseArray(Object[] arr)
        {
            //chuyen 1 mang doi tuong thanh mang string
            return (string[])arr.Select((a) => a.ToString()).ToArray();
        }

        public static void Method(out int answer, out string message, out string stillNull)
        {
            //tim hieu key out
            answer = 44;
            message = "I've been returned";
            stillNull = null;
        }
        public static double[] FindLargest(double[][] values)
        {
            //tinh tong cac array con
            return values.Select((value) => value.Max()).ToArray();
        }

        public static int[] ArrayOfMultiples(int num, int length)
        {
            //xuat ra 1 mang voi num*length
            return Enumerable.Range(1, length).Select((value) => value * num).ToArray();
        }

        public static string ReversCase(string str)
        {
            //chuyen hoa thanh thuong va nguoc lai
            return new string(str.ToArray().Select((c) => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
        }

        public static string Bomd(string txt)
        {
            //tim tu bomb 
            return Regex.IsMatch(txt, @"(?i)bomb") ? "Duck!!!" : "There is no bomb, relax.";
        }

        public static string Bomb1(string txt)
        {

            return txt.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
        }

        public static int[] CountPossSumNeg(double[] arr)
        {
            // tinh tong so am va dem so duong
            //return new[] {arr.Count(n => n > 0), (int)arr.Sum(n => n < 0 ? n : 0)};
            if (arr.Length == 0)
            {
                return new int[0];
            }
            int count = 0, sum = 0;
            foreach (var a in arr)
            {
                if (a <= 0)
                {
                    sum += (int)a;
                }
                else
                {
                    count++;
                }
            }
            return new int[] { count, sum };
        }


    }
}
