using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Solution
    {



        public static int solution(int N)
        {
            var maxGap = 0;
            var count = 0;
            var foundOne = false;

            while ( N > 0)
            {
                if ((N & 1) == 0)
                {
                  count++;          
                } else {
                    if (foundOne && count > maxGap)
                    {
                        maxGap = count;
                    }
                    count = 0;
                    foundOne = true;
                }
                N = N >> 1;
            }

            return maxGap;

        }


    }
}
