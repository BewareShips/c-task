using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Task1
    {
        public List<int> TwoDigitsArr = new List<int>();

        public void TakingCardNumberFromUser( )
        {
            Console.WriteLine("Type a cardNumber");
            var str = Console.ReadLine().Replace(" ","");

            int[] numbers = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                numbers[i] = int.Parse(str[i].ToString());
            }
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] *= 2;
                }
            }

            for (int i = 0; i < numbers.Length; i += 2)
            {
                
                TwoDigitsArr.Add(numbers[i] * 10 + (numbers[i + 1]));
                
            }
            int totalSumOfTwoDigitsNums = TwoDigitsArr.Sum(i => i);
            Console.WriteLine($"total sum is {totalSumOfTwoDigitsNums}");
        }


    }
}
