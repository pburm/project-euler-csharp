using ProjectEuler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class Solution0004 : ISolution
    {
        public void Solve()
        {
            var result = 0;
            var number1 = 0;
            var number2 = 0;
            var product = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    product = i * j;
                    if (product > result && product.ToString().IsPalindrome())
                    {
                        number1 = i;
                        number2 = j;
                        result = product;
                    }
                }
            }

            Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is {result} ({number1} * {number2})");
        }
    }
}
