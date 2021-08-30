using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Task6
    {
        public void FindSubarrayWithSumNull(int[] num)
        {
            bool found = false;

            for( int i = 0; i < num.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < num.Length; j++)
                {
                    sum += num[j];
                    if (sum == 0)
                    {
                        found = true;
                        break;
                    }
                }
            }
            Console.WriteLine("Found " + found);
        }
    }
}
