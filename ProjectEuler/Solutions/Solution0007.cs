using ProjectEuler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions
{
    public class Solution0007 : ISolution
    {
        public void Solve()
        {
            var result = 13;
            var temp = result;
            var nth = 6;
            while (nth < 10001)
            {
                temp += 2;
                if (temp.IsPrime())
                {
                    result = temp;
                    nth++;
                }
                    
            }
            Console.WriteLine($"The 10001st prime number is {result}");
        }
    }
}
