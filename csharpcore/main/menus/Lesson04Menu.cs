using csharpcore.main.classwork.lesson04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.menus
{
    class Lesson04Menu
    {
        static double a;

        public static void Menu()
        {
            Console.WriteLine(".........................................................................................");
            Console.WriteLine("Choose the program by entering the number");
            Console.WriteLine("Menu items");
            Console.WriteLine("1. Circle area calculation");
            Console.WriteLine("2. Choosing bigger circle area");
            Console.WriteLine("3. Is the triangle right angled?");
            Console.WriteLine("4. Odd/Even analizer");
            Console.WriteLine("*****************************************************");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Enter program number : ");
                a = Convert.ToDouble(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("Input radius = ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input pi = ");
                    double pi = Convert.ToDouble(Console.ReadLine());
                    double result = CircleRadius.Calculate(radius, pi);
                    Console.WriteLine("Circle area is " + result);
                }
                else if (a == 2)
                {
                    Console.WriteLine("radius1 = ");
                    double radius1 = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("radius2 = ");
                    double radius2 = Convert.ToDouble(Console.ReadLine());

                    double result = CircleArea.CalculateBigger(radius1, radius2);
                    if (result == radius1)
                    {
                        Console.WriteLine("First circle is bigger");
                    }
                    else if (result == radius2) { Console.WriteLine("Second circle is bigger"); }
                    else { Console.WriteLine("Equal circles"); }
                }
                else if (a == 3)
                {
                    Console.WriteLine("input a=");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("input b=");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("input c=");
                    double c = Convert.ToDouble(Console.ReadLine());
                    bool result = TriangleCheck.Check(a, b, c);
                    if (result)
                    {
                        Console.WriteLine("Triangle is right angled");
                    }
                    else Console.WriteLine("Triangle is not right angled");

                }
                else if (a == 4)
                {
                    Console.WriteLine("Input k=");
                    double k = Convert.ToDouble(Console.ReadLine());
                    bool result1 = IsEven.IsEven1(k);
                    if (result1)
                    {
                        Console.WriteLine("Even");
                    }
                    else Console.WriteLine("Not even");

                }
                else
                {
                    Console.WriteLine("Please choose the number from 1 to 4 only");
                }

                Console.WriteLine("*****************************************************");
                Console.ReadLine();
            }
        }
    }
}
