using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array must not be empty.", nameof(numbers));

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
    }
}
