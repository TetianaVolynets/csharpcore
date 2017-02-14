using csharpcore.main.classwork.lesson03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.menus
{
    class Lesson03Menu
    {
        public static void Menu()
        {
            Console.WriteLine("Input a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Multiplying gives" +MathFunc.Multiply(a, b));
            Console.WriteLine("Division gives" + MathFunc.Divide(a, b));
            Console.WriteLine("Adding gives" + MathFunc.Add(a, b));
            Console.WriteLine("DMinusing gives" + MathFunc.Minus(a, b));

        }
    }
}
