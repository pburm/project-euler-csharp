using ProjectEuler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class Solution0002 : ISolution
    {
        public void Solve()
        {
            var sum = 0;
            var f = Numbers.Fibonacci();
            var current = 0;

            while (current <= 4000000)
            {
                current = f();
                if (current % 2 == 0)
                    sum += current;
            }

            Console.WriteLine($"Sum of the even Fibonacci numbers below 4000000 is {sum}");
        }
    }
}
