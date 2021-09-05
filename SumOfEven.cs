using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class SumOfEven
    {
        public void  FindNumbers(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if(item.ToString().Length %2 == 0)
                {
                    sum += 1;
                }
            }
            Console.WriteLine($"There are a {sum } Even Number of Digits");
        }
    }
}
