using ProjectEuler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class Solution0003 : ISolution
    {
        public void Solve()
        {
            var result = 1;
            var num = 600851475143;
            for (int i = 3; i < (int)Math.Sqrt(num); i+=2)
            {
                if (num % i == 0 && i.IsPrime())
                    result = i;
            }

            Console.WriteLine($"The largest prime factor of the number 600851475143 is {result}");
        }
    }
}
