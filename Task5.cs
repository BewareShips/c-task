using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Task5
    {
        public List<int> nums = new List<int> { };
        public void MaximumElement()
        {
            Console.WriteLine("Please type a number of operations");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please type a queries");
                string[] query = Console.ReadLine().Split();

                
                    switch (query[0])
                    {
                        case "1":
                            nums.Add(int.Parse(query[1]));
                            Console.WriteLine( $"{query[1]} is added to list");

                            break;
                        case "2":
                            if (nums.Count > 0)
                            {
                                nums.RemoveAt(nums.Count - 1);
                            }
                            Console.WriteLine("last nums was deleted");
                            break;
                        case "3":
                            Console.WriteLine($"{nums.Max()} is Max number");
                            break;
                        default:

                            Console.WriteLine("Wrong number");
                            break;
                    
                }
            }

        }

    }
}
