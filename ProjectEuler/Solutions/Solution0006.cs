using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class Solution0006 : ISolution
    {
        public void Solve()
        {
            var sum = 0;
            var sumOfSquares = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
                sumOfSquares += (int)Math.Pow(i, 2);
            }
            var result = Math.Pow(sum, 2) - sumOfSquares;
            Console.WriteLine($"The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is {result}");
        }
    }
}
