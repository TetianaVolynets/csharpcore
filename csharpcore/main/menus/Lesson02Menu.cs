using csharpcore.main.classwork.lesson02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.menus
{
    class Lesson02Menu
    {
        public static void Menu() {
            float fl = 435435.01f;
            int integer = 12;
            char ch = 'x';
            PrimitiveConvertor primitiveConvertor = new PrimitiveConvertor();
            //primitiveConvertor.charToInt(ch);
            //primitiveConvertor.intToChar(integer);
            //primitiveConvertor.floatToChar(fl);
            Console.WriteLine("Input float value is " + fl + ". Output char value is " + primitiveConvertor.floatToChar(fl));
            Console.WriteLine("Input int value is " + integer + ". Output char value is " + primitiveConvertor.intToChar(integer));
            Console.WriteLine("Input char value is " + ch + ". Output int value is " + primitiveConvertor.charToInt(ch));
            Console.ReadLine();
        }
    }
}
