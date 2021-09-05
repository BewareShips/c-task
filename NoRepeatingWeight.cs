using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class NoRepeatingWeight
    {
        public void NoRepeatingValue(int[] num)
        {
            var uniqueNums = num.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key);
            foreach (var item in uniqueNums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
