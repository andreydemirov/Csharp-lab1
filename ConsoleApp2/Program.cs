using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО А");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("НАПИШІТЬ ЧислО В");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a/b=" + (a / b));
        }
    }
}