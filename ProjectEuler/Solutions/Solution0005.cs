using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class Solution0005 : ISolution
    {
        public void Solve()
        {
            var result = 2520;
            var currentNumber = result;
            var found = false;
            while (!found)
            {
                result = currentNumber;
                for (int i = 11; i < 21; i++)
                {
                    if (result % i != 0)
                    {
                        currentNumber++;
                        break;
                    }
                        
                }
                if (currentNumber == result)
                    found = true;
            }

            Console.WriteLine($"The smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is {result}");
        }
    }
}
