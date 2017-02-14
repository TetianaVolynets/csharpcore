using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.classwork.lesson04
{
    class IsEven
    {public static bool IsEven1(double val)
        {
            
            /*if ((int)val/2 ==(double)val/2) {
                return true;
            }
            else
            {
                return false;
            }*/
            return (int)val/2 ==(double)val/2? true : false;
            
        }
    }
}
