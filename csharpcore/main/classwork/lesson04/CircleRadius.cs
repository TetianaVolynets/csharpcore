using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.classwork.lesson04
{
    public class CircleRadius
    {
        

        public static int Calculate(double radius, double pi)
           
        {
            
            double circleArea = pi * Math.Pow(radius, 2);
            return (int)circleArea;
        }
    }
}
