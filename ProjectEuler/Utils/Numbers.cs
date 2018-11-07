using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Utils
{
    public static class Numbers
    {
        public static bool IsPrime(this int x)
        {
            if (x % 2 == 0)
                return x == 2;

            int testUpTo = (int)((Math.Sqrt(x) + 1));
            for (int i = 3; i < testUpTo; i += 2)
            {
                if ((x % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static Func<int> Fibonacci()
        {
            var last1 = 0;
            var last2 = 1;
            return () => {
                var temp = last1 + last2;
                last2 = last1;
                last1 = temp;
                return last1;
            };

        }
    }
}
