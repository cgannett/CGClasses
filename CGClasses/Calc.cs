using System;
using System.Collections.Generic;
using System.Linq;
namespace CGClasses
{
    public static class Calc
    {

        public static int Add(int x, int y)
        { return x + y; }
        public static int Sub(int x, int y)
        { return x - y; }
        public static int Mult(int x, int y)
        { return x * y; }
        public static int Div(int x, int y)
        { return x / y; }
        public static long Fact(int x)
        {
           if (x == 0)
            { return 1; }
           if (x > 20)
            { return 0; }
           return x*Calc.Fact(x-1);
        }

        
    }

}
