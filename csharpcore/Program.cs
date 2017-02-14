using csharpcore.main.menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Choose the Lesson number");

                double a = Convert.ToDouble(Console.ReadLine());

                if (a == 4)
                {
                    for (int j = 0; j <= 1; j++) {
                        Lesson04Menu.Menu();
                    }
                        
                    
                }
                else if (a == 3)
                {
                    Lesson03Menu.Menu();
                }
                else if (a == 2)
                {
                    Lesson02Menu.Menu();
                }
            }
            Console.ReadLine();
        
           

        }
    }
}
