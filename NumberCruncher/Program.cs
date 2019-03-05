using System;
using System.Collections.Generic;

namespace NumberCruncher
{
    public static class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Console.WriteLine(NumberUtility.NumberCruncher.SumOfEvenNumbers(numbers));

            Console.ReadLine();
        }
    }
}
