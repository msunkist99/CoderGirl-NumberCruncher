using System;
using System.Collections.Generic;
using System.Text;

namespace NumberUtility
{
    public static class NumberCruncher
    {
        public static int SumOfEvenNumbers(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if ((numbers[i] % 2 == 0))
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }
    }
}
