using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.classwork.lesson04
{
    class TriangleCheck
    {
        public static bool Check(double a, double b, double c)
        {

            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a) || (a * b * c == 0) && (a > 0) && (b > 0) && (c > 0)){
                return true;
            } else {
            return false;}

            }
            }
        

        }

