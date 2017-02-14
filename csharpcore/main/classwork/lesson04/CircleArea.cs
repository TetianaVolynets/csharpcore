using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.classwork.lesson04
{
    class CircleArea
    {
        public const double PI = 3.14d;
        public static double CalculateBigger(double radius1, double radius2)

        {
            // radius = Convert.ToDouble(Console.ReadLine());
            double area1 = PI * radius1 * radius1;
            double area2 = PI * radius2 * radius2;
            if (area1 > area2)
            {

                return radius1;
            }
            else if (area1 < area2)
            {

                return radius2;
            }
            else
            {
                return 0;
            }

        }
    }
}
