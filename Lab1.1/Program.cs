using System;
using System.Linq;
using lab;

namespace Lab1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task();

        }
        static void task()
        {
            SClass test = new SClass("SHdRVBAHskaBJSyHfD");
            Console.WriteLine("String: " + test.ToString());
            Console.WriteLine("Sorted: " + test.sort());
            Console.WriteLine("Length: " + test.length());

        }
    }
}
