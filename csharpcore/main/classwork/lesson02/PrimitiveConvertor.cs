using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.main.classwork.lesson02
{
    class PrimitiveConvertor
    {
        public char floatToChar(float float1)
        {
            char charFloatResult = (char)float1;
            return charFloatResult;

        }
        public char intToChar(int int1)
        {
            char charIntResult = (char)int1;
            return charIntResult;


        }
        public int charToInt(char char1)
        {
            int intCharResult = (int)char1;
            return intCharResult;

        }
    }
}
