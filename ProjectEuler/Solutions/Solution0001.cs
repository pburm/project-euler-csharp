using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class Solution0001 : ISolution
    {
        public void Solve()
        {
            var result = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }


            Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is {result}");
        }
    }
}
