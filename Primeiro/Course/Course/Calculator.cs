using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Calculator
    {
        public static void Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

        }
    }
}
