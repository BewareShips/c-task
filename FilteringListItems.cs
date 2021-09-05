using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class FilteringListItems
    {
        public List<int> nums = new List<int> { };

        

        public void AddNumberToList()
        {
            Console.WriteLine("Type please a number");
            int num = int.Parse( Console.ReadLine());
            
            if (num > 0)
            {
                nums.Add(num);
                AddNumberToList();
            }
            else
            {
                Console.WriteLine("Sorry, You type a negative number");
                ShowListItems();
                
            }
           
        }

        public void ShowListItems()
              
        {
            var sortNums = nums.OrderBy(o=>o).ToList();

            double average = nums.Average();

            int mode = nums.GroupBy(item => item).OrderByDescending(i => i.Count()).First().Key;

            Console.WriteLine("Sorted nums are");
            foreach (var item in sortNums)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine($"Average number is {average}");
            Console.WriteLine($"Mode number is {mode}");


        }
    }
}
