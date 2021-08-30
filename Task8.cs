using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Task8
    {
        public void  RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                Console.WriteLine("nums.Length"); 
            int index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                    nums[++index] = nums[i];
            }
            Console.WriteLine(index + 1) ;
        }
    }
}
