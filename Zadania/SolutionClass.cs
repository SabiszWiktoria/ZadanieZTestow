using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        { 
            if (number % 2 == 0)
            {
                return "Even";
            }
            return "Odd";
        }
    }
}
